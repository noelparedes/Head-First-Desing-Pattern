using System;
using System.Collections.Generic;
using Observer_Pattern.Observer;
using Observer_Pattern.ConcreteSubject;
namespace Observer_Pattern.ConcreteObservers
{
    public class phoneDisplay:IObserver
    {
        private float _temp;
        private float _humidity;
        private float _pressure;
        private WeatherData weatherData;

        public phoneDisplay(WeatherData weatherdata)
        {
            this.weatherData = weatherdata;
            //weatherData.registerObserver(this);
       
        }
        public void update(float temperature, float humidity, float pressure)
        {
            this._temp = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            this.display();
        
            
        }


        public void display()
        {
            Console.WriteLine("Phone Display-------");
            Console.WriteLine("Current conditions:" + this._temp + " F degrees and: " + this._humidity + "% humidity:" + this._pressure + "% pressure" );
        }
        
     
    }
}