using Kanadeiar.Desktop.Forms;
using Task7WeatherForecastCore.WeatherModule;

namespace Task7WeatherForecastApp
{
    public partial class MainForm : Form, IFormObserver
    {
        private readonly WeatherForecast _forecast;

        public MainForm()
        {
            InitializeComponent();

            _forecast = new WeatherForecast();
            _forecast.AddObserver(this);
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                await _forecast.UpdateData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при получении прогноза погоды:\n" + exception.Message, 
                    "Получение прогноза погоды", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(IFormObservable observed, object? arg)
        {
            if (observed is WeatherForecast forecast)
            {
                labelMorning.Text = forecast.MorningData;
                labelDay.Text = forecast.DayData;
                labelEvening.Text = forecast.EveningData;
                labelNight.Text = forecast.NightData;
            }
        }
    }
}
