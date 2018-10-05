using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace DarkSky_dotnet.Models
{
	public class GoogleApi
	{
		readonly string APIKey;
		readonly Uri baseURL = new Uri("https://maps.googleapis.com/maps/api/geocode/");
		HttpClient client = new HttpClient();

		public GoogleApi(string key)
		{
			this.APIKey = key;
			client.BaseAddress = baseURL;
		}

		/// <summary>
		/// Requests geolocation information from google based on the latitude and longitude provided.
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <returns></returns>
		public async Task<string> GetAddress(double lat, double lon)
		{
			object[] objects = { APIKey, lat, lon };
			var requestURL = string.Format("xml?key={0}&latlng={1:N4},{2:N4}", objects);
			HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, requestURL);
			var response = await client.SendAsync(message);
			var responseContent = await response.Content.ReadAsStringAsync();

			var xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(responseContent);

			XmlNodeList nodeList = xmlDocument.GetElementsByTagName("short_name");

			object[] addressComponents = {
				xmlDocument.DocumentElement.ChildNodes[1].ChildNodes[4].ChildNodes[1].InnerText,
				xmlDocument.DocumentElement.ChildNodes[1].ChildNodes[6].ChildNodes[1].InnerText
			};

			string address = string.Format("{0},{1}", addressComponents);
			return address;
		}
	}
}