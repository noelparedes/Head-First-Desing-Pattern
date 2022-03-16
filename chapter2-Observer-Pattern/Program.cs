using System;

namespace chapter2_Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            phoneDisplay phone = new phoneDisplay(weatherData);
   
           
            weatherData.registerObserver(phone);
            currentDisplay.update(82,70,29.4f);
            phone.display();
          // currentDisplay.display();
            
        }
    }
}
