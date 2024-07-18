using Newtonsoft.Json;

namespace Task7WeatherForecastCore.WeatherModule.WeatherData;

internal class Hourly
{
    [JsonProperty("time")]
    public List<DateTime> Time;

    [JsonProperty("temperature_2m")]
    public List<double?> Temperature2m;

    [JsonProperty("wind_speed_10m")]
    public List<double?> WindSpeed10m;
}