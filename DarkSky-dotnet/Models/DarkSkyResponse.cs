using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	public class DarkSkyResponse
	{
		[JsonProperty(PropertyName = "latitude")]
		public double Latitude { get; set; }

		[JsonProperty(PropertyName = "longitude")]
		public double Longitude { get; set; }

		[JsonProperty(PropertyName = "timezone")]
		public string Timezone { get; set; }

		[JsonProperty(PropertyName = "currently")]
		public Data Currently { get; set; }

		[JsonProperty(PropertyName = "minutely")]
		public DataBlock Minutely { get; set; }

		[JsonProperty(PropertyName = "hourly")]
		public DataBlock Hourly { get; set; }

		[JsonProperty(PropertyName = "daily")]
		public DataBlock Daily { get; set; }

	}
}