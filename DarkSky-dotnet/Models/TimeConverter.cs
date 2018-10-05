using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkSky_dotnet.Models
{
	public static class TimeConverter
	{
		public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
		{
			System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
			dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
			return dtDateTime;
		}
	}
}