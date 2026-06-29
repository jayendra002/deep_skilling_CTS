using ObserverPatternExample.Observers;
using ObserverPatternExample.Observers;

namespace ObserverPatternExample.Subjects
{
    public interface Stock
    {
        void RegisterObserver(Observer observer);

        void RemoveObserver(Observer observer);

        void NotifyObservers();
    }
}