using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkSky_dotnet.Models
{
	
	public class WeatherViewModel
	{
		public DarkSkyResponse darkSky { get; set; }
		public string address { get; set; }
	}
}