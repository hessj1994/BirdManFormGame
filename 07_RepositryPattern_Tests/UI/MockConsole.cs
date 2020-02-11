using _07_RepositoryPattern_ConsoleUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositryPattern_Tests.UI
{
    class MockConsole : IConsole //22. dif assembly, bring in using statement, reference. wont have ref or use interface at first, no access modifier in IConsole. maually add reference, right click on test assembly, add referecne
        //accessable to multiple methods,make classinside of class, order matters when making a collection, queue class to go down the list, take it out, next first thing should be 7(exit)
    {
        private Queue<string> _userInput;//23. want to decalre on construction of class, ctor tabtab
        public MockConsole(IEnumerable<string> input)
        {
            _userInput = new Queue<string>(input);//overloads allows IEnum, called input, all options will show in queue
        }
        //24. defined input, define output
        public string Output { get; set; } = "";//25. default value of blank string, want it to be accessible outside of code, get set works as well, type doesnt matter.
        //26. making a prop of class output of type string, will be able to directly see output in tests

                //27.  equals, plus add something to it
        public void Clear()
        {
            Output = Output + "Called Clear Method\n";//output += ""
        }

        public ConsoleKeyInfo ReadKey()
        {//28. built around any key, 
            return new ConsoleKeyInfo();
            // returns a struct, always have a value, cannot be set to null
            //not required to add to the output that something was called, prev+=
        }

        public string ReadLine()
        {//29. get something from queue, method is dequeue
            string nextInput = _userInput.Dequeue();//can peek without removing, dequeue removes it
            return nextInput;
            //single line, return _userInput.Dequeue();

        }

        public void Write(string str)
        {//30.  instead of writing to console, store in output
            Output += str;
        }

        public void WriteLine(string str)
        {
            Output += str + "\n";//adding new line
        }

        public void WriteLine(object obj)
        {
            Output += obj + "\n";
        }
    }
}