using Newtonsoft.Json;

namespace Task7WeatherForecastCore.WeatherModule.WeatherData;

internal class HourlyUnits
{
    [JsonProperty("time")]
    public string Time;

    [JsonProperty("temperature_2m")]
    public string Temperature2m;

    [JsonProperty("wind_speed_10m")]
    public string WindSpeed10m;
}