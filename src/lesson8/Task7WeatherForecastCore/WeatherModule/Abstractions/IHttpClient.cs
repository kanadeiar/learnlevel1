namespace Task7WeatherForecastCore.WeatherModule.Abstractions;

public interface IHttpClient
{
    Task<string> GetStringAsync(string url);
}