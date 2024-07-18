namespace Task7WeatherForecastApp
{
    public partial class MainForm : Form
    {
        private const string ADDRESS = "https://api.open-meteo.com/v1/forecast?latitude=53.20&longitude=45.00&hourly=temperature_2m,wind_speed_10m&forecast_days=1";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //var client = new HttpClient();
            //var response = await client.GetStringAsync(ADDRESS);

            //var weather = JsonConvert.DeserializeObject<Weather>(response);



        }
    }





}
