using System.Diagnostics;

namespace ConsoleApp2.Functions
{
    internal class CommonMethods
    {
        public static string directory = null;
        public static string command = null;
        public static void consoleWriter(string message) => Console.WriteLine(message);

        public static void executeCommand(string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = @directory;
            startInfo.Arguments = $"/C {command} {arguments}";
            startInfo.Verb = "runas";

            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;

            Process process = new Process();

            Process.Start(startInfo);
        }

    }
}
