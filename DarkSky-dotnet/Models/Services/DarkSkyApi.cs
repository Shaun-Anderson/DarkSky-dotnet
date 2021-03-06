﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DarkSky_dotnet.Models;

namespace DarkSky_dotnet.Services
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

		/// <summary>
		/// Requests weather information from dark sky based on the latitude and longitude provided.
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <returns></returns>
		public async Task<DarkSkyResponse> GetForcast(double lat, double lon)
		{
			var requestURL = string.Format("forecast/" + APIKey + "/{0:N4},{1:N4}", lat, lon);
			HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, requestURL);
			var response = await client.SendAsync(message);
			var responseContent = await response.Content.ReadAsStringAsync();

			// If success continue. 
			if(response.IsSuccessStatusCode)
			{
				// Deserialize JSON into DarkSkyResponse object.
				DarkSkyResponse responseObject = JsonConvert.DeserializeObject<DarkSkyResponse>(responseContent);
				return responseObject;
			}

			return null;
		}

	}
}