using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{

    public static IWebDriver driver;

    public static void DebugChrome(string portNumber)
    {
        var options = new ChromeOptions();
        options.AddExperimentalOption("debuggerAddress", $"localhost:{portNumber}");
        driver = new ChromeDriver(options);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Port");
        string portNumber = Console.ReadLine();
        DebugChrome(portNumber);

    }
}