using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者5
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);


            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(30, 80, 60);
            weatherData.SetMeasurements(45, 10, 33.3f);
            weatherData.SetMeasurements(29, 77, 90.5f);


            Console.ReadKey();

        }
    }
}
