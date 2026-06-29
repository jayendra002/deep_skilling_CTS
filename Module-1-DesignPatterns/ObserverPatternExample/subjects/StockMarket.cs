using ObserverPatternExample.Observers;

namespace ObserverPatternExample.Subjects
{
    public class StockMarket : Stock
    {
        private List<Observer> observers = new List<Observer>();

        private double stockPrice;

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void SetStockPrice(double price)
        {
            stockPrice = price;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(stockPrice);
            }
        }
    }
}