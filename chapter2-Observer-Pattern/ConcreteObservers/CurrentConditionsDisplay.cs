using Observer_Pattern.DisplayElement;
using Observer_Pattern.Observer;
using Observer_Pattern.ConcreteSubject;
using System;

namespace Observer_Pattern.ConcreteObservers
{
    public class CurrentConditionsDisplay:IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private WeatherData _weatherdata;

        public CurrentConditionsDisplay(WeatherData weatherdata)
        {
            this._weatherdata = weatherdata;
           //weatherdata.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
            
        }

        public void display()
        {
            Console.WriteLine("Current  a Display------");
            Console.WriteLine("Current conditions:" + temperature + "F degrees and " + humidity + "% humidity" + pressure + "% pressure");
            
        }
    }
}