﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UCUI.Models;
using UCUI.UserControls;
using System.Media;
using CSharpServer;
using System.Threading;
using System.Windows.Interop;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Controls.Primitives;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;

namespace UCUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[] ButtonArray;
        private Server server;
        private HttpClient client;
        private HwndSource windowHandle;

        private const string SERVER_ADDRESS = "http://localhost:8080/";

        // USB Message Constants
        private const int WM_DEVICECHANGE = 0x219;
        private const int WM_DEVICEARRIVAL = 0x8000;
        private const int WM_DEVICEREMOVECOMPLETE = 0X8004;


        // Threading Management
        private Thread newThread;
        private delegate void CallingDelegate();
        private Random random = new Random();


        public MainWindow()
        {

            InitializeComponent();
            DataContext = new UCSettings();
            try
            {
                ControlOptions.ItemsSource = ControlSource.Options;
                
                
            }
            catch (TypeInitializationException)
            {
                TitleBlock.Text = "Make sure the Control Options folder is set up correctly!";
                OptionsHeader.Text = "Couldn't list options";
            }
            if (File.Exists("UCConfig.txt"))
            {
                try
                {
                    string lines = System.IO.File.ReadAllText("UCConfig.txt");

                    string[] words = lines.Split(' ');

                    for (int i = 0; i < 9; i++)
                    {
                        UCSettings.SetKey(words[i], i);
                    }
                    ((UCSettings)DataContext).IsCenter = words[9] == "True";
                    ((UCSettings)DataContext).IsHover = words[10] == "True";
                    ((UCSettings)DataContext).IsShake = words[11] == "True";
                    ((UCSettings)DataContext).IsSound = words[12] == "True";
                }
                catch(Exception)
                {
                    TitleBlock.Text = "Could not load settings from UCConfig.txt";
                }

            }
            // Server script
            var serverThread = new Thread(ServerRoutine);
            serverThread.Start();
            client = new HttpClient()
            {
                BaseAddress = new Uri(SERVER_ADDRESS)
            };

            // Obtain window handle and attach system message hook
            var handle = new WindowInteropHelper(this).EnsureHandle();
            windowHandle = HwndSource.FromHwnd(handle);
            windowHandle.AddHook(new HwndSourceHook(WndProc));

            Task.Run(() =>
            {
                serverThread.Join();
                server.ObtainUSBDeviceInfo();
                server.ObtainRemoteDeviceInfo();
            });
            server.RaiseUINotifEvent += Server_RaiseUINotifEvent;
        }

        private void Server_RaiseUINotifEvent(object sender, string e)
        {
            MessageBox.Show(e);
        }




        #region
        // Region of Code for USB device events
        /// <summary>
        /// Callback function for message processing
        /// </summary>
        /// <param name="hwnd">Window Handle</param>
        /// <param name="msg">Message</param>
        /// <param name="wParam">Main Message</param>
        /// <param name="lParam">Secondary Message</param>
        /// <param name="handled"></param>
        /// <returns></returns>
        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case WM_DEVICECHANGE:
                    switch ((uint)wParam.ToInt32()) {
                        case WM_DEVICEARRIVAL:
                            NotifyServer(SERVER_ADDRESS + Notif.DeviceDetected, "");
                            break;
                        case WM_DEVICEREMOVECOMPLETE:
                            NotifyServer(SERVER_ADDRESS + Notif.DeviceDisconnected, "");
                            break;

                    }
                    break;
            }
            return IntPtr.Zero;
        }

        
        
        #endregion
        private void PageOpen(object sender, RoutedEventArgs e)
        {
            Button myButton = (Button)sender;
            switch (myButton.Content)
            {
                case "Settings":
                    SettingsView.Visibility = System.Windows.Visibility.Visible;
                    break;
                case "Help":
                    HelpView.Visibility = System.Windows.Visibility.Visible;
                    break;
            }
            Overlay.Visibility = Visibility.Visible;
            Outside.Visibility = Visibility.Visible;
            MainView.Effect = new BlurEffect();
            CheckCenterMouse();
        }

        private void Outside_Click(object sender, RoutedEventArgs e)
        {
            HelpView.Visibility = System.Windows.Visibility.Collapsed;
            SettingsView.Visibility = System.Windows.Visibility.Collapsed;
            Outside.Visibility = Visibility.Collapsed;
            Overlay.Visibility = Visibility.Collapsed;
            MainView.Effect = null;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonGrid.Children.Clear();

            if (ControlOptions.SelectedItem != null)
            {
                ButtonArray = new Button[9];
                ControlOption myOption = (ControlOption)ControlOptions.SelectedItem;
                int visibleButtonCounter=0;
                for (int i = 0; i < 9; i++)
                {
                    ButtonArray[i] = new Button();

                    if (myOption.buttonVisible[i])
                    {


                        ButtonArray[i].Content = i.ToString();
                        string disp = i.ToString();
                        ButtonArray[i].Name = "Button" + i.ToString();
                        ButtonArray[i].Content = myOption.buttonLabels[visibleButtonCounter];
                        ButtonArray[i].Margin = new Thickness(10, 10, 10, 10);
                        Grid.SetColumn(ButtonArray[i], i % 3 + 1);
                        Grid.SetRow(ButtonArray[i], i / 3 + 1);
                        ButtonGrid.Children.Add(ButtonArray[i]);
                        ButtonArray[i].Style = (Style)Application.Current.Resources["Pusher"];

                        ButtonArray[i].PreviewMouseDown += delegate (object a, MouseButtonEventArgs b)
                        {
                            if (((UCSettings)DataContext).IsSound) UCMethods.PlayMySound();
                        };

                        ButtonArray[i].Click += delegate (object a, RoutedEventArgs b)
                        {
                            // Get DeviceInfo Object
                            Button sourceButton = (Button)a;
                            string buttonName = sourceButton.Name;
                            int buttonIndex = Int32.Parse(buttonName.Substring(6));

                            // To replace "AL5D" with reference from the selected menu or button
                            ControllerDevice currentDevice = server.ConnectedDeviceList["smart lamp"];
                            DeviceInfo currentDeviceInfo = currentDevice.DeviceInfo;

                            if (currentDeviceInfo.ApiType == "LocalLib")
                            {
                                
                                int count = currentDeviceInfo.FunctionArray.Count;
                                if (buttonIndex > count - 1) { }
                                else
                                {
                                    Task.Run(() =>
                                    {
                                        MethodInfo methodToBind = server.GetMethodInfo(currentDevice, currentDeviceInfo.FunctionArray[buttonIndex].Name);
                                        methodToBind.Invoke(currentDevice.DeviceObject, null);
                                    });
                                }
                            }
                            else if (currentDeviceInfo.ApiType == "Http")
                            {
                                Dictionary<string, string> messageDict = new Dictionary<string, string>
                                {
                                    ["name"] = "smart lamp",
                                };

                                NotifyServer(SERVER_ADDRESS + Notif.PostToServer, JsonConvert.SerializeObject(messageDict));
                            }
                            CheckCenterMouse();
                        };

                        ButtonArray[i].MouseEnter += delegate (object a, MouseEventArgs b)
                        {
                            if (((UCSettings)DataContext).IsHover)
                            {
                                CheckSound();
                                ((Button)a).RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                            }

                        };
                        visibleButtonCounter++;
                    }
                }

                if (myOption.textBoxVisible)
                {
                    TextBox myTextbox = new TextBox();
                    myTextbox.TextWrapping = TextWrapping.Wrap;
                    myTextbox.Name = "TextInput";
                    myTextbox.FontSize = 36;
                    Grid.SetColumn(myTextbox, 1);
                    Grid.SetRow(myTextbox, 1);
                    Grid.SetColumnSpan(myTextbox, 3);
                    ButtonGrid.Children.Add(myTextbox);
                }
                HeaderPic.Source = new BitmapImage(myOption.actualUri);
                TitleBlock.Text = myOption.name;
            }
            CheckCenterMouse();


        }

        private void CheckCenterMouse()
        {
            if (((UCSettings)DataContext).IsCenter)
                UCMethods.SetPosition(this);

        }

        private void CheckSound()
        {
            if (((UCSettings)DataContext).IsSound)
                UCMethods.PlayMySound();
        }



        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (SettingsView.Visibility != Visibility.Visible)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (UCSettings.GetKey(i) == e.Key.ToString()&& ButtonArray[i].Content != null)
                    {
                        ((UCSettings)DataContext).ButtonKey = "Button" + i.ToString();
                        ButtonArray[i].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                        CheckSound();
                        break;
                    }
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            ((UCSettings)DataContext).ButtonKey = "ButtonNull";
        }

        private void ServerRoutine()
        {
            server = new Server(SERVER_ADDRESS);
            server.Run();
            //deviceInterface.TestRoboticArm();

        }

        private void NotifyServer(string url, string content)
        {
            Task.Run(() =>
            {
                HttpRequestMessage message = new HttpRequestMessage()
                {
                    Method = new HttpMethod("POST"),
                    Content = new StringContent(content),
                    RequestUri = new Uri(url)
                };
                message.Headers.Add("Content-Type", "application/json");
                client.SendAsync(message);
            });
        }
        

    }
    

}