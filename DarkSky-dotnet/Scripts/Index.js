// On load
$(function () {
	CalcWeather();
	setInterval(function () { CalcWeather(); }, 10000);
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
		console.log("Position Calculated for location: " + position.coords.latitude + " | " + position.coords.longitude);
		CallToServer(position.coords.latitude, position.coords.longitude);
	}
	var geoError = function (error) {
		console.log('Error occurred. Error code: ' + error.code);
	}
	navigator.geolocation.getCurrentPosition(geoSuccess, geoError);
}

// Use .load to get the PartialView and load it into #partialView
function CallToServer(lat, lon) {
	$("#partialView").load("/Home/GetWeather", { lat: lat, lon: lon });
}