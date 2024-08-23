using ConsoleApp2.Data;
using log4net;
using log4net.Config;
using static ConsoleApp2.Functions.CommonMethods;

class MainClass
{


    static void Main(string[] args)
    {

        XmlConfigurator.Configure();

        ILog logger = LogManager.GetLogger("Remote Debug");

        consoleWriter("Enter Browser Name");
        string browser = new string(Console.ReadLine());
        browser = browser.ToLower();

        bool result = false;


        if (browser == "edge")
        {

            directory = BrowserData.getEdge();
            command = $"ms{browser}.exe";
            result = true;
        }
        else if (browser == "chrome")
        {

            directory = BrowserData.getChrome();
            command = $"{browser}.exe";
            result = true;

        }
        else
        {

            logger.Error($"{browser.ToUpper()} Browse Name Misspelled. Please Use 'Edge' (or) 'Chrome'");

            Thread.Sleep(5000);


        }



        if (result == true)
        {
            consoleWriter("Enter Port Number");
            string port = new string(Console.ReadLine());

            // command to execute
            string arguments = $"--remote-debugging-port={port} --user-data-dir=\"C:\\Remote Browser Debug\\Browsers\\{browser.ToUpper()}\\Port {port}\"";
            executeCommand(arguments);

            logger.Info($"{browser.ToUpper()} Browser Opened on {port} successfully");



        }

    }
}