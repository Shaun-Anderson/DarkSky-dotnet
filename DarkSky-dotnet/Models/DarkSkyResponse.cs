using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	public class DarkSkyResponse
	{
		[JsonProperty(PropertyName = "currently")]
		public CurrentData Currently { get; set; }

		[JsonProperty(PropertyName = "latitude")]
		public double Latitude { get; set; }

		[JsonProperty(PropertyName = "longitude")]
		public double Longitude { get; set; }

		[JsonProperty(PropertyName = "timezone")]
		public double Timezone { get; set; }
	}
}