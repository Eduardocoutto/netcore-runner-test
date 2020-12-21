using System;

namespace Runner4
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public double TemperatureC { get; set; }

        public double TemperatureF => 32 + (TemperatureC * 1.8);

        public string Summary { get; set; }
    }
}
