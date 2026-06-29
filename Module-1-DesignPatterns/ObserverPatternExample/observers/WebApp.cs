namespace ObserverPatternExample.Observers
{
    public class WebApp : Observer
    {
        public void Update(double price)
        {
            Console.WriteLine($"Web App: Stock price updated to {price}");
        }
    }
}