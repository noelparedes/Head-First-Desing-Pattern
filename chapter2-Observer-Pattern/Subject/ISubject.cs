using chapter2_Observer_Pattern.Observer;
namespace chapter2_Observer_Pattern.Subject
{
    public interface ISubject
    {
         public void registerObserver(IObserver observer);
         public void removeObserver(IObserver observer);
         public void notifyObserver();
    }
}