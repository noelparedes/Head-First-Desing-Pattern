using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer_Pattern.Observer;
using Observer_Pattern.ConcreteSubject;
using Observer_Pattern.DisplayElement;

namespace Observer_Pattern.ConcreteObservers
{
    public class ForecastDisplay:IObserver,IDisplayElement
    {
        private float _temp;
        private float _humidity;
        private float _pressure;

        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
           this._weatherData = weatherData;
            //weatherData.registerObserver(this);
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

            Console.WriteLine("Forecast Active Display--------");
            Console.WriteLine("Current conditions:" + this._temp + " F degrees and: " + this._humidity + "% humidity:" + this._pressure + "% pressure");
        }
    }
}
