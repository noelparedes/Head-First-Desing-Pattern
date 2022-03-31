using System;
using Observer_Pattern.ConcreteSubject;
using Observer_Pattern.ConcreteObservers;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new  CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            
            weatherData.setMeasurements(80, 68, 30.4f);
            weatherData.removeObserver(forecastDisplay);
            weatherData.registerObserver(statisticsDisplay);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);


       
        }
    }
}

