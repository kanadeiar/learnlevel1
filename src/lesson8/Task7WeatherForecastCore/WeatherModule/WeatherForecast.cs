using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;
using Task7WeatherForecastCore.WeatherModule.Abstractions;
using Task7WeatherForecastCore.WeatherModule.Adapters;
using Task7WeatherForecastCore.WeatherModule.WeatherData;

[assembly: InternalsVisibleTo("Task7WeatherForecastCoreTests")]
namespace Task7WeatherForecastCore.WeatherModule
{
    public class WeatherForecast : ModelBase
    {
        private const string ADDRESS = "https://api.open-meteo.com/v1/forecast?latitude=53.20&longitude=45.00&hourly=temperature_2m,wind_speed_10m&forecast_days=1";

        internal static IHttpClient client = new HttpClientAdapter();

        public string MorningData { get; set; } = string.Empty;
        
        public string DayData { get; set; } = string.Empty;
        
        public string EveningData { get; set; } = string.Empty;
        
        public string NightData { get; set; } = string.Empty;
        
        public async Task UpdateData()
        {
            var response = await client.GetStringAsync(ADDRESS);
            var weather = JsonConvert.DeserializeObject<Weather>(response);

            if (weather == null) return;

            MorningData = $"Утро: температура {weather.Hourly.Temperature2m[8]} °C, ветер: {weather.Hourly.WindSpeed10m[8]} км/ч";
            DayData = $"День: температура {weather.Hourly.Temperature2m[13]} °C, ветер: {weather.Hourly.WindSpeed10m[13]} км/ч";
            EveningData = $"Вечер: температура {weather.Hourly.Temperature2m[18]} °C, ветер: {weather.Hourly.WindSpeed10m[18]} км/ч";
            NightData = $"Ночь: температура {weather.Hourly.Temperature2m[23]} °C, ветер: {weather.Hourly.WindSpeed10m[23]} км/ч";

            NotifyObservers();
        }
    }
}
