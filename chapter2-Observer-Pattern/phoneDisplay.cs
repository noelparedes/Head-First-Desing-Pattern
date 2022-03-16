using System;
using chapter2_Observer_Pattern.Observer;
namespace chapter2_Observer_Pattern
{
    public class phoneDisplay:IObserver
    {
         private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public phoneDisplay(WeatherData weatherdata)
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