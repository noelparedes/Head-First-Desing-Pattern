using Observer_Pattern.ConcreteSubject;
using Observer_Pattern.DisplayElement;
using Observer_Pattern.Observer;
using System;


namespace Observer_Pattern.ConcreteObservers
{
    public class StatisticsDisplay : IObserver,IDisplayElement
    {
        private float _temp;
        private float _humidity;
        private float _pressure;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
           // weatherData.registerObserver(this);
        }
        public void update(float temp, float humidity, float pressure)
        {
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            display();
        }
        public void display()
        {
            Console.WriteLine("Statistic Display");
            Console.WriteLine("Current conditions:" + this._temp + " F degrees and: " + this._humidity + "% humidity:" + this._pressure + "% pressure");
        }

       
    }
}
