$("#start-step").on("click", function() {
	var time = ($(this).attr("value"));
	getTimer(time * 60);
})

var socket;
var reading = 0;
var tempLimit = Number($("#temperature-reading").attr("value"));
var tempPlayed = false;
var tempAudio = new SpeechSynthesisUtterance("The pan is too hot, turn the heat down!");
var tempAudio2 = new SpeechSynthesisUtterance("The pan is not yet hot enough, please keep waiting");
var tempAudio3 = new SpeechSynthesisUtterance("The required temperature has been reached");


    var voices = window.speechSynthesis.getVoices();
    tempAudio.voice = voices.filter(function(voice) { return voice.name == 'Google UK English Male'; })[0];
    tempAudio2.voice = voices.filter(function(voice) { return voice.name == 'Google UK English Male'; })[0];
    tempAudio3.voice = voices.filter(function(voice) { return voice.name == 'Google UK English Male'; })[0];

socket = io.connect("https://e02372f1a67d4f56b0b98313ca0e64f0.vfs.cloud9.us-east-2.amazonaws.com");
socket.on("connect", function() {
	this.on("newTemp", (data) => {
		if (data !== reading) {
			reading = data;
			$("#temperature-reading").text(reading);
			if(reading < tempLimit) {
				$("temperature-reading").toggleClass("alert");
				window.speechSynthesis.speak(tempAudio2);
			}
			else if(reading > tempLimit) {
				$("temperature-reading").removeClass("alert");
				window.speechSynthesis.speak(tempAudio);
			}
			else {
				window.speechSynthesis.speak(tempAudio3);	
			}
		}
		/*$("#temperature-reading").text(reading);
		if(reading > tempLimit) {
			$("#temperature-reading").toggleClass("alert");
			if (!tempPlayed) {
				window.speechSynthesis.speak(tempAudio);
			//	tempPlayed = true;
			}
		}
		else if (reading < tempLimit) {	
		//	$("#temperature-reading").toggleClass("alert");
			if (!tempPlayed) {
				window.speechSynthesis.speak(tempAudio2);
			//	tempPlayed = true;
			}
				else {
		//	$("#temperature-reading").removeClass("alert");
				window.speechSynthesis.speak(tempAudio3);
			//  tempPlayed = true;
			}

		}*/
	})
})

function getTimer(stepTime) {
	var timer = new Timer();
	timer.start({countdown: true, startValues: {seconds: stepTime}});
	$('#countdownExample .values').html(timer.getTimeValues().toString());
	timer.addEventListener('secondsUpdated', function (e) {
	    $('#countdownExample .values').html(timer.getTimeValues().toString());
	});
	timer.addEventListener('targetAchieved', function (e) {
		var msg = new SpeechSynthesisUtterance("Well done! Time's up, go to the next step!");
		window.speechSynthesis.speak(msg);
	    setInterval(function() {
	    	$('#countdownExample .values').toggleClass("alert");
	    }, 1000);
	});
}


function enableMute() { 
    
    tempAudio.volume = 0;
    tempAudio2.volume = 0;
    tempAudio3.volume = 0;
    
} 

function disableMute() { 
	
    tempAudio.volume = 1;
    tempAudio2.volume = 1;
    tempAudio3.volume = 1;

    
} 

