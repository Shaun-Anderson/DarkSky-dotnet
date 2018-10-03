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

		public async Task<ActionResult> WeatherPost (double lat, double lon)
		{
			DarkSkyApi api = new DarkSkyApi("abe5243cd0a2445af3fc3f8581caa352");
			await api.GetForcast(lat, lon);
			return PartialView();
		}

	}
}