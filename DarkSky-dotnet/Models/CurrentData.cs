using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	public class CurrentData
	{
		private double Celcius;

		[JsonProperty(PropertyName = "time")]
		public string Time;

		[JsonProperty(PropertyName = "summary")]
		public string Summary;

		[JsonProperty(PropertyName = "icon")]
		public string Icon;

		// Returns degrees in Fahrenheit format.
		[JsonProperty(PropertyName = "temperature")]
		public double Temperature {
			get { return Celcius; }
			set { Celcius = 5.0 / 9.0 * (value - 32); }
		}

	}
}