using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI.UI
{
    public interface IConsole
    {
        //readline returns void, writeline returns string
        string ReadLine();
        void Write(string str);//1. can be placed in any order, def will list all the potential inputs, write will keep input on same line
        void WriteLine(string str);//2. is list a string? no, need to build an overloaded method
        void WriteLine(object obj);//3. every type inherits from object, will use a string or obj depending
        void Clear();//4. takes in no params
        //5. ref old code to see what type these return, void, string, readkey example
        ConsoleKeyInfo ReadKey();//6. hover, wont accept shift, cntrl, alt keys, not keys themselves, just modifiers
        //7. just have interface, no implementation yet
    }
}
