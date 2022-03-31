using Observer_Pattern.Observer;
namespace Observer_Pattern.Subject
{
    public interface ISubject
    {
         public void registerObserver(IObserver observer);
         public void removeObserver(IObserver observer);
         public void notifyObserver();
    }
}