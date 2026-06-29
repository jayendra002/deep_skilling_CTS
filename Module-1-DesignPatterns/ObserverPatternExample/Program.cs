using ObserverPatternExample.Subjects;
using ObserverPatternExample.Observers;

StockMarket stockMarket = new StockMarket();

Observer mobile = new MobileApp();
Observer web = new WebApp();

stockMarket.RegisterObserver(mobile);
stockMarket.RegisterObserver(web);

stockMarket.SetStockPrice(1500);

stockMarket.SetStockPrice(1800);