using Newtonsoft.Json;

namespace Task7WeatherForecastCore.WeatherModule.WeatherData;

internal class Weather
{
    [JsonProperty("latitude")]
    public double? Latitude;

    [JsonProperty("longitude")]
    public double? Longitude;

    [JsonProperty("generationtime_ms")]
    public double? GenerationtimeMs;

    [JsonProperty("utc_offset_seconds")]
    public int? UtcOffsetSeconds;

    [JsonProperty("timezone")]
    public string Timezone;

    [JsonProperty("timezone_abbreviation")]
    public string TimezoneAbbreviation;

    [JsonProperty("elevation")]
    public double? Elevation;

    [JsonProperty("hourly_units")]
    public HourlyUnits HourlyUnits;

    [JsonProperty("hourly")]
    public Hourly Hourly;
}