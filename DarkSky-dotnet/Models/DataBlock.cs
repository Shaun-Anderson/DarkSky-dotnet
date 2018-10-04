using System.Collections.Generic;
using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	public class DataBlock
	{
		[JsonProperty(PropertyName = "data")]
		public List<Data> Data { get; set; }

		[JsonProperty(PropertyName = "icon")]
		public string Icon { get; set; }

		[JsonProperty(PropertyName = "summary")]
		public string Summary { get; set; }
	}
}