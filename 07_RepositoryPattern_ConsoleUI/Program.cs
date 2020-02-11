using _07_RepositoryPattern_ConsoleUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RealConsole console = new RealConsole();//22. new up, pass into new programui method, breakpoint here to see paths
            ProgramUI ui = new ProgramUI(console);//21. after replacing, need to pass in arguement that matches IConsole type
            ui.Run();
        }
    }
}
