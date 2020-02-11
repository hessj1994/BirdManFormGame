using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 34;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Craig", "Justin", "Isaiah" };
            int x = 1;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class {students[i]}!");
            }

        }
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total <= 11)
            {
                Console.WriteLine(total);
                total += 3;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                    //break;
                }

            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Nick", "Craig", "Justin", "Isaiah", "Tom", "Un Yon", "Josh" };
            foreach (string child in students)
            {
                Console.WriteLine(child + "is a child");
            }

            string myName = "Amanda Joy Knight";

            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            List<List<string>> listOfLists = new List<List<string>>();
            foreach (List<string> list in listOfLists)
            {
                foreach (string str in list)
                {

                }
            }
        }

        [TestMethod]
        public void KeyChallenge()
        {
            /*Your client needs a secure key for their website's customers. You need to write the code that generates a string that has 10 random alphanumeric characters. Your client would like the each code to not include any vowels. He also hates the number 13, so make sure none of your codes include the number 13!


            string that has 10 random alphanumeric characters.
                All possible characters I can use - array (collection)
                Random number generator
                Pick a number in the range between 0 and count (-1) of items in char array and store it
                Get the character that matches the random number (index)
                Add the random character to our string

            Your client would like the each code to not include any vowels.
            
            He also hates the number 13, so make sure none of your codes include the number 13!
                Check the last character and see if it is a 1
                    If it is a 1, and our current character is a 3, continue
             */

            //Type     Name     = value
            string customerKey = "";
            string characters = "BCDFGHJKLMNPQRSTVWXYZ0123456789";
            Random rand = new Random();

            while (customerKey.Length < 10)
            {
                int randomNumber = rand.Next(0, characters.Length);
                char nextCharacter = characters[randomNumber];

                if (customerKey.EndsWith("1") && nextCharacter == '3')
                {
                    continue;
                }

                customerKey = customerKey + nextCharacter; // customerKey += nextCharacter;
            }

            Console.WriteLine(customerKey);
        }
    }
}
