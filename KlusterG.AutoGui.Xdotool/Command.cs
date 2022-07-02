using System.Diagnostics;

namespace KlusterG.AutoGui.Xdotool
{
    internal class Command
    {
        public string Process { get; set; }
        public List<string> Args { get; set; }
        public string Output { get; private set; }

        public Command() { }

        public void Run()
        {
            string response = "";

            using (Process command = new Process())
            {
                command.StartInfo.FileName = Process;

                string args = "";

                if (Args != default)
                {
                    foreach (string arg in Args)
                    {
                        args += " " + arg;
                    }
                }

                command.StartInfo.Arguments = args;
                command.StartInfo.UseShellExecute = false;
                command.StartInfo.CreateNoWindow = true;
                command.StartInfo.RedirectStandardOutput = true;
                command.StartInfo.RedirectStandardError = true;
                command.Start();
                command.WaitForExit();

                Output = command.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(Output)) Output = command.StandardError.ReadToEnd();
            }
        }
    }
}
