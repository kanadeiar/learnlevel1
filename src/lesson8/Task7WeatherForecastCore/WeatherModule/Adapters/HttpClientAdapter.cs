using Task7WeatherForecastCore.WeatherModule.Abstractions;

namespace Task7WeatherForecastCore.WeatherModule.Adapters
{
    public class HttpClientAdapter : IHttpClient
    {
        private HttpClient _httpClient = new();

        public Task<string> GetStringAsync(string url)
        {
            return _httpClient.GetStringAsync(url);
        }
    }
}
