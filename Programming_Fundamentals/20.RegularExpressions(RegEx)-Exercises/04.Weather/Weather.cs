using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    public class WeatherInfo
    {
        public double Temperature { get; set; }

        public string Weather { get; set; }
    }
    class Weather
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var weatherInfos = new Dictionary<string, WeatherInfo>();


            while (input != "end")
            {
                var pattern = @"(?<city>[A-Z]{2})(?<temp>\d{2}\.\d+)(?<weather>[a-zA-Z]+)\|";

                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    var city = match.Groups["city"].Value;
                    var temp = double.Parse(match.Groups["temp"].Value);
                    var weather = match.Groups["weather"].Value;

                    var weatherInfo = new WeatherInfo()
                    {
                        Temperature = temp,
                        Weather = weather
                    };

                    weatherInfos[city] = weatherInfo;
                }

                input = Console.ReadLine();
            }

            weatherInfos = weatherInfos.OrderBy(a => a.Value.Temperature).ToDictionary(a => a.Key, a => a.Value);

            foreach (var info in weatherInfos)
            {
                Console.WriteLine($"{info.Key} => {info.Value.Temperature:F2} => {info.Value.Weather}");
            }
        }
    }
}
