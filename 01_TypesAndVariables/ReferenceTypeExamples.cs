using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Amanda";
            string lastName = "Knight";
            string concatenatedFullName = "Hello there"+ firstName + " " + lastName + ".";
            Console.WriteLine(concatenatedFullName);

            string compositeFullName = string.Format("Hello {1} {0} {0}", firstName, "Whatever");
            Console.WriteLine(compositeFullName);

            string interpolatedFullName = ($"Hello {firstName} {lastName}. Whatever I wanted. {firstName}");
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("First string in our list");
            listOfInts.Add(32);
            listOfStrings.AddRange(stringArray);

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next in line");
            string firstItem = firstInFirstOut.Dequeue();

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(22, "string");
            string value22 = keyAndValue[22];
            Console.WriteLine(value22);

            SortedList<int, string> sortedKeyAndValuePair = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next(5,10);
            Console.WriteLine(randomNumber);

        }
    }
}
