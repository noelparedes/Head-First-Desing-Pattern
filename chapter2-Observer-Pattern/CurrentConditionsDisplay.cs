using chapter2_Observer_Pattern.DisplayElement;
using chapter2_Observer_Pattern.Observer;
using System;
namespace chapter2_Observer_Pattern
{
    public class CurrentConditionsDisplay:IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherdata)
        {
            this.weatherData = weatherData;
           // weatherData.registerObserver(this.display);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
            
        }

        public void display()
        {
        Console.WriteLine("Current conditions:" + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}