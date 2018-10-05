using System.Collections.Generic;
using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	/// <summary>
	/// Data block representing the data for weather over time.
	/// More Information about Data Blocks can be found at the link below:
	/// https://darksky.net/dev/docs#/dev/docs#response-format
	/// </summary>
	public class DataBlock
	{
		[JsonProperty(PropertyName = "data")]
		public List<DataPoint> Data { get; set; }

		[JsonProperty(PropertyName = "icon")]
		public string Icon { get; set; }

		[JsonProperty(PropertyName = "summary")]
		public string Summary { get; set; }
	}
}