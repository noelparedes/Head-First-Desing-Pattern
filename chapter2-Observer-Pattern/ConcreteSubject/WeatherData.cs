using System.Collections.Generic;
using System.Collections;
using System;

using Observer_Pattern.Subject;
using Observer_Pattern.Observer;

namespace Observer_Pattern.ConcreteSubject
{
    public class WeatherData: ISubject
    {
        private List<IObserver> observers;


        private float temperature;
        private float humidity;
        private float pressure;
        
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        
      
        public void registerObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }
        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
       public void notifyObserver()
       {
         foreach (IObserver listObserver in observers)
         {
             listObserver.update(temperature,humidity,pressure);
         }
       }
       public void measurementsChanged()
       {
           notifyObserver();
       }
       public void setMeasurements(float temperature, float humidity,float pressure)
       {
           this.temperature = temperature;
           this.humidity = humidity;
           this.pressure = pressure;
          measurementsChanged();
       }

       

    }
}