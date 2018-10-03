using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace DarkSky_dotnet.Models
{
	public class DarkSkyApi
	{
		readonly string APIKey;
		readonly Uri baseURL = new Uri("https://api.darksky.net/");
		HttpClient client = new HttpClient();

		public DarkSkyApi (string key)
		{
			this.APIKey = key;
			client.BaseAddress = baseURL;
		}


		public async Task GetForcast(double lat, double lon)
		{
			var requestURL = "forecast/" + APIKey + "/" + lat + "," + lon + "))";
			HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, requestURL);
			var response = await client.SendAsync(message);
			var responseContent = await response.Content.ReadAsStringAsync();

			//TODO: Create responce object to reteive ViewModel data.
		}

	}
}