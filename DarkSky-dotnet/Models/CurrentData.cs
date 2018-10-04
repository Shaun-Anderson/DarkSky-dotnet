using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	public class CurrentData
	{
		// Returns degrees in Fahrenheit format.
		[JsonProperty(PropertyName = "temperature")]
		public double Temperature { get; set; }
	}
}