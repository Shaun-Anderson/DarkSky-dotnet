using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DarkSky_dotnet.Models
{
	
	[JsonConverter(typeof(DarkSkyEnumJsonConverter))]
	public enum Icon
	{
		[EnumMember(Value = null)]
		None,

		[EnumMember(Value = "clear-day")]
		CLEAR_DAY,

		[EnumMember(Value = "clear-night")]
		CLEAR_NIGHT,

		[EnumMember(Value = "rain")]
		RAIN,

		[EnumMember(Value = "snow")]
		SNOW,

		[EnumMember(Value = "sleet")]
		SLEET,

		[EnumMember(Value = "wind")]
		WIND,

		[EnumMember(Value = "fog")]
		FOG,

		[EnumMember(Value = "cloudy")]
		CLOUDY,

		[EnumMember(Value = "partly-cloudy-day")]
		PARTLY_CLOUDY_DAY,

		[EnumMember(Value = "partly-cloudy-night")]
		PARTLY_CLOUDY_NIGHT,
	}
}