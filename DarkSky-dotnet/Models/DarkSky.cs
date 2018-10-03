using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace DarkSky_dotnet.Models
{
	public class DarkSkyApi
	{
		readonly string APIKey;
		readonly Uri baseURL = new Uri("https://api.darksky.net/");

		public DarkSkyApi (string key)
		{
			this.APIKey = key;
		}


		public async Task GetFromAPI(double lat, double lon)
		{

		}

	}
}