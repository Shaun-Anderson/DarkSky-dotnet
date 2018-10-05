using System.Web.Mvc;
using DarkSky_dotnet.Models;
using DarkSky_dotnet.Services;
using System.Threading.Tasks;

namespace DarkSky_dotnet.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// Retrieves data from APIs and adds them to the view model, then returns a partial view with the model.
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <returns></returns>
		public async Task<ActionResult> GetWeather (double lat, double lon)
		{
			WeatherViewModel model = new WeatherViewModel();

			DarkSkyApi api = new DarkSkyApi("abe5243cd0a2445af3fc3f8581caa352");
			model.darkSky = await api.GetForcast(lat, lon);

			GoogleApi googleAPI = new GoogleApi("AIzaSyCM01T2NMZlHFJ05U0kRU0SPUotqWcMdzM");
			model.address = await googleAPI.GetAddress(lat, lon);

			return PartialView("/Views/Home/_index.cshtml", model);


		}

	}
}