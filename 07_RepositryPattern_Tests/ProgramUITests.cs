using System;
using System.Collections.Generic;
using _07_RepositoryPattern_ConsoleUI.UI;
using _07_RepositryPattern_Tests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositryPattern_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void AddToList_ShouldSeeItemInOutput()
        {
            //31.   Console.WriteLine("Enter Your Name:");//cant rely on console class
            //21. change it up to test the mock console
            //string name = Console.ReadLine();//2) doesnt expect any value, will wait for userinput, wouldnt be able to test the UI, cant test something the UI is dependant upon
            //31.   string name = "Joshua";
            //31.   Console.WriteLine(name);//1) at this point, if tested, will wait for the readline, cant use readline in a unit test
            //33.   Start by adding a command list, with vars, if tracked types
            //34.   object initialization 

            //38.   Arrange
            List<string> commandList = new List<string>()
            {
                "4",
                "Title",
                "Description",
                "Genre",
                "5",//expecting int
                "2",//options from programui list of maturyity rating
                "4",
                "Language",
                "7"//exit condition, can have intentionally nonsense data for further testing. can also do on one line
            };
            //35.   in dif namespace, using statement, requires IEnumerable(commandList)
            MockConsole console = new MockConsole(commandList);
            //36.   program ui, check if public, change if necessary to bring in using statemeent
            ProgramUI ui = new ProgramUI(console);//37. pass in IConsole, MockConsole instance
            //Arrange, Act, Assert
            //39..    Act, how to run? call run method from ProgramUI
            ui.Run();
            Console.WriteLine(console.Output);//40.    write to console output of MockConsole, everything recorded in Output property, inserted into console = new MockConsole(commandList)

        }
    }
}
