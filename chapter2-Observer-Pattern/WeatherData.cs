using System.Collections.Generic;
using System.Collections;

using chapter2_Observer_Pattern.Subject;
using chapter2_Observer_Pattern.Observer;

namespace chapter2_Observer_Pattern
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
            observers.Add(observer);
        }
        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
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