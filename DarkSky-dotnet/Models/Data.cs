using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	/// <summary>
	/// Class for wrapping current, minutely, hourly and daily data from Dark Sky.
	/// </summary>
	public class Data
	{

		#region Temperature Values

		[JsonProperty(PropertyName = "temperature")]
		public double? Temperature { get; set; }
		public double? TemperatureCelsius => 5.0 / 9.0 * (Temperature - 32);

		[JsonProperty(PropertyName = "temperatureHigh")]
		public double? TemperatureHigh { get; set; }

		[JsonProperty(PropertyName = "temperatureLow")]
		public double? TemperatureLow { get; set; }

		[JsonProperty(PropertyName = "apparentTemperature")]
		public double? ApparentTemperature { get; set; }

		[JsonProperty(PropertyName = "apparentTemperatureHigh")]
		public double? ApparentTemperatureHigh { get; set; }

		[JsonProperty(PropertyName = "apparentTemperatureLow")]
		public double? ApparentTemperatureLow { get; set; }

		#endregion

		[JsonProperty(PropertyName = "cloudCover")]
		public double? CloudCover { get; set; }

		[JsonProperty(PropertyName = "dewPoint")]
		public double? DewPoint { get; set; }

		[JsonProperty(PropertyName = "humidity")]
		public double? Humidity { get; set; }

		[JsonProperty(PropertyName = "icon")]
		public Icon Icon { get; set; }

		[JsonProperty(PropertyName = "moonPhase")]
		public double? MoonPhase { get; set; }

		[JsonProperty(PropertyName = "nearestStormBearing")]
		public int? NearestStormBearing { get; set; }

		[JsonProperty(PropertyName = "nearestStormDistance")]
		public double? NearestStormDistance { get; set; }

		[JsonProperty(PropertyName = "ozone")]
		public double? Ozone { get; set; }

		#region Precipitation Values

		[JsonProperty(PropertyName = "precipAccumulation")]
		public double? PrecipAccumulation { get; set; }

		[JsonProperty(PropertyName = "precipIntensity")]
		public double? PrecipIntensity { get; set; }

		[JsonProperty(PropertyName = "precipIntensityError")]
		public double? PrecipIntensityError { get; set; }

		[JsonProperty(PropertyName = "precipIntensityMax")]
		public double? PrecipIntensityMax { get; set; }

		[JsonProperty(PropertyName = "precipProbability")]
		public double? PrecipProbability { get; set; }

		[JsonProperty(PropertyName = "precipType")]
		public string PrecipType { get; set; }

		#endregion

		[JsonProperty(PropertyName = "pressure")]
		public double? Pressure { get; set; }

		[JsonProperty(PropertyName = "summary")]
		public string Summary { get; set; }

		#region Temperature



		#endregion

		[JsonProperty(PropertyName = "uvIndex")]
		public int? UvIndex { get; set; }

		[JsonProperty(PropertyName = "visibility")]
		public double? Visibility { get; set; }

		#region Wind values

		[JsonProperty(PropertyName = "windBearing")]
		public int? WindBearing { get; set; }

		[JsonProperty(PropertyName = "windGust")]
		public double? WindGust { get; set; }

		[JsonProperty(PropertyName = "windSpeed")]
		public double? WindSpeed { get; set; }

		#endregion

		#region Time Values

		[JsonProperty(PropertyName = "apparentTemperatureHighTime")]
		internal long? ApparentTemperatureHighTimeUnix { get; set; }

		[JsonProperty(PropertyName = "apparentTemperatureLowTime")]
		internal long? ApparentTemperatureLowTimeUnix { get; set; }

		[JsonProperty(PropertyName = "precipIntensityMaxTime")]
		internal long? PrecipIntensityMaxTimeUnix { get; set; }

		[JsonProperty(PropertyName = "sunriseTime")]
		internal long? SunriseTimeUnix { get; set; }

		[JsonProperty(PropertyName = "sunsetTime")]
		internal long? SunsetTimeUnix { get; set; }

		[JsonProperty(PropertyName = "temperatureHighTime")]
		internal long? TemperatureHighTimeUnix { get; set; }

		[JsonProperty(PropertyName = "temperatureLowTime")]
		internal long? TemperatureLowTimeUnix { get; set; }

		[JsonProperty(PropertyName = "time")]
		internal long TimeUnix { get; set; }

		[JsonProperty(PropertyName = "uvIndexTime")]
		internal long? UvIndexTimeUnix { get; set; }

		[JsonProperty(PropertyName = "windGustTime")]
		internal long? WindGustTimeUnix { get; set; }

		#endregion
	}
}