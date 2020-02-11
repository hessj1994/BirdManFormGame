using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI.UI
{
    class RealConsole : IConsole
    {//8. cntl . implement IConsole
        public void Clear()
        {
            Console.Clear();//9. Feed console into ui
        }

        public ConsoleKeyInfo ReadKey()//10. needs a return
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine(); //12. string output = ... return output, same
        }

        public void Write(string str)
        {
            Console.Write(str);//11. pass into console method as arguement
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
        
    }
}
