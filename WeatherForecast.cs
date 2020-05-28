using System;

namespace ODataOffsetProblemPOC
{
    public class WeatherForecast
    {
        public DateTimeOffset StartDate { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
