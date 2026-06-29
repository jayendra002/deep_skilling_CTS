namespace ObserverPatternExample.Observers
{
    public class MobileApp : Observer
    {
        public void Update(double price)
        {
            Console.WriteLine($"Mobile App: Stock price updated to {price}");
        }
    }
}