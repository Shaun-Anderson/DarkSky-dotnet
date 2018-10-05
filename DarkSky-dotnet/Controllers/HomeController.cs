using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DarkSky_dotnet.Models;
using System.Threading.Tasks;

namespace DarkSky_dotnet.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public async Task<ActionResult> GetWeather (double lat, double lon)
		{
			WeatherViewModel model = new WeatherViewModel();

			DarkSkyApi api = new DarkSkyApi("abe5243cd0a2445af3fc3f8581caa352");
			model.darkSky = await api.GetForcast(lat, lon);

			GoogleMapsApi googleAPI = new GoogleMapsApi("AIzaSyCM01T2NMZlHFJ05U0kRU0SPUotqWcMdzM");
			model.address = await googleAPI.GetAddress(lat, lon);

			return PartialView("/Views/Home/_index.cshtml", model);


		}

	}
}