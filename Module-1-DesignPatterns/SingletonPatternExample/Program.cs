using SingletonPatternExample;

Logger logger1 = Logger.GetInstance();

Logger logger2 = Logger.GetInstance();

logger1.Log("Application Started");

if (ReferenceEquals(logger1, logger2))
{
    Console.WriteLine("Same Logger Instance");
}
else
{
    Console.WriteLine("Different Logger Instance");
}