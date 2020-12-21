using System;
using Xunit;

namespace Runner4.test
{
    public class WeatherForecast_Temperature
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(25, 77)]
        [InlineData(30, 86)]
        public void TemperatureF_(int celcius, int fahrenheit)
        {

            var weatherForecast = new WeatherForecast
            {
                TemperatureC = celcius,
            };

            Assert.Equal(fahrenheit, weatherForecast.TemperatureF);
        }
    }
}
