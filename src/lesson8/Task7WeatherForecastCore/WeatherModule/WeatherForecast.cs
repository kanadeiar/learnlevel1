using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Kanadeiar.Desktop.Forms;
using Task7WeatherForecastCore.WeatherModule.Abstractions;
using Task7WeatherForecastCore.WeatherModule.Adapters;
using Task7WeatherForecastCore.WeatherModule.WeatherData;
using System.Globalization;

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

            MorningData = TextGen("Утро", weather.Hourly, 8);
            DayData = TextGen("День", weather.Hourly, 13); 
            EveningData = TextGen("Вечер", weather.Hourly, 18);
            NightData = TextGen("Ночь", weather.Hourly, 23);

            NotifyObservers();  
            
            return;

            string TextGen(string text, Hourly hourly, int i) => string.Format(CultureInfo.InvariantCulture, "{0}: температура {1} °C, ветер: {2} км/ч", text, hourly.Temperature2m[i], hourly.WindSpeed10m[i]);
        }
    }
}
