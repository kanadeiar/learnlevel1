using AutoFixture.Xunit2;
using FluentAssertions;
using Kanadeiar.Desktop.Forms;
using Kanadeiar.Tests;
using Moq;
using Task7WeatherForecastCore.WeatherModule;
using Task7WeatherForecastCore.WeatherModule.Abstractions;

namespace Task7WeatherForecastCoreTests.WeatherModule;

public class WeatherForecastTests
{
    [Theory]
    [AutoMoqData]
    public void TestGetData([Frozen] Mock<IHttpClient> mock)
    {
        mock.Setup(x => x.GetStringAsync(It.IsAny<string>())).ReturnsAsync(TEST_JSON);
        WeatherForecast.client = mock.Object;
        var forecast = new WeatherForecast();

        forecast.UpdateData().Wait();

        forecast.MorningData.Should().Contain("Утро: температура 30,9 °C, ветер: 8,9 км/ч");
        forecast.DayData.Should().Contain("День: температура 30,8 °C, ветер: 13,6 км/ч");
        forecast.EveningData.Should().Contain("Вечер: температура 23,8 °C, ветер: 4,3 км/ч");
        forecast.NightData.Should().Contain("Ночь: температура 18,8 °C, ветер: 4,3 км/ч");
    }

    [Theory]
    [AutoMoqData]
    public void TestNotify([Frozen] Mock<IHttpClient> mock, [Frozen] Mock<IFormObserver> observerMock)
    {
        mock.Setup(x => x.GetStringAsync(It.IsAny<string>())).ReturnsAsync(TEST_JSON);
        WeatherForecast.client = mock.Object;
        IFormObservable observable = new WeatherForecast();
        observable.AddObserver(observerMock.Object);

        observable.NotifyObservers();

        observerMock.Verify(x => x.Update(observable, It.IsAny<object>()), Times.Once);
    }

    private const string TEST_JSON = 
@"{
    ""latitude"": 53.1875,
    ""longitude"": 45.0,
    ""generationtime_ms"": 0.03898143768310547,
    ""utc_offset_seconds"": 0,
    ""timezone"": ""GMT"",
    ""timezone_abbreviation"": ""GMT"",
    ""elevation"": 156.0,
    ""hourly_units"": {
        ""time"": ""iso8601"",
        ""temperature_2m"": ""°C"",
        ""wind_speed_10m"": ""km/h""
    },
    ""hourly"": {
        ""time"": [
            ""2024-07-18T00:00"",
            ""2024-07-18T01:00"",
            ""2024-07-18T02:00"",
            ""2024-07-18T03:00"",
            ""2024-07-18T04:00"",
            ""2024-07-18T05:00"",
            ""2024-07-18T06:00"",
            ""2024-07-18T07:00"",
            ""2024-07-18T08:00"",
            ""2024-07-18T09:00"",
            ""2024-07-18T10:00"",
            ""2024-07-18T11:00"",
            ""2024-07-18T12:00"",
            ""2024-07-18T13:00"",
            ""2024-07-18T14:00"",
            ""2024-07-18T15:00"",
            ""2024-07-18T16:00"",
            ""2024-07-18T17:00"",
            ""2024-07-18T18:00"",
            ""2024-07-18T19:00"",
            ""2024-07-18T20:00"",
            ""2024-07-18T21:00"",
            ""2024-07-18T22:00"",
            ""2024-07-18T23:00""
        ],
        ""temperature_2m"": [
            17.3,
            17.0,
            17.3,
            18.8,
            22.1,
            24.4,
            27.4,
            29.5,
            30.9,
            31.5,
            32.2,
            31.5,
            31.9,
            30.8,
            30.5,
            29.1,
            28.1,
            25.9,
            23.8,
            22.4,
            21.3,
            20.3,
            19.4,
            18.8
        ],
        ""wind_speed_10m"": [
            3.1,
            3.2,
            3.1,
            2.6,
            3.1,
            5.5,
            6.4,
            8.4,
            8.9,
            11.0,
            11.0,
            13.0,
            11.6,
            13.6,
            12.3,
            9.4,
            6.7,
            5.2,
            4.3,
            4.7,
            5.0,
            4.5,
            4.7,
            4.3
        ]
    }
}";
}