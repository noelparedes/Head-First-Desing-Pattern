namespace chapter2_Observer_Pattern.Observer
{
    public interface IObserver
    {
         public void update(float temp, float humidity, float pressure);
    }
}