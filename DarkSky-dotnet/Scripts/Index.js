﻿// On load
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
		console.log("Position Calculated for location: " + position.coords.latitude + " | " + position.coords.longitude);
		CallToServer(position.coords.latitude, position.coords.longitude);
	}
	var geoError = function (error) {
		console.log('Error occurred. Error code: ' + error.code);
	}
	navigator.geolocation.getCurrentPosition(geoSuccess, geoError);
}

function CallToServer(lat, lon) {
	console.log(lat + " | " + lon);
	$.ajax({
		type: "POST",
		url: "Home/WeatherPost",
		data: '{"lat": ' + lat + ',' + '"lon": ' + lon + '}',
		contentType: "application/json; charset=utf-8",
		dataType: "json",
		success: function (response) {
			$("#partialView").html(response);
		},
		failure: function (response) {
			alert(response);
		}
	});
}