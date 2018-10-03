// On load
$(function () {
	$("#calcButton").click(CalcWeather);
});

// Use browsers navigator 
function CalcWeather() {

	// check for Geolocation support
	if (navigator.geolocation) {
		console.log('Geolocation is supported!');
	}
	else {
		console.log('Geolocation is not supported for this Browser/OS.');
		return;
	}

	var startPos;
	var geoSuccess = function (position) {
		startPos = position;
		console.log("Position Calculated.");
	}
	var geoError = function (error) {
		console.log('Error occurred. Error code: ' + error.code);
	}
	navigator.geolocation.getCurrentPosition(geoSuccess, geoError);
}