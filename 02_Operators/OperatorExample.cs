using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class OperatorExample
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 23;
            int b = 25;

            int sum = a + b;
            Console.WriteLine(sum);

            int difference = a - b;
            Console.WriteLine(difference);

            int product = a * b;
            Console.WriteLine(product);

            double quotient = (double)a / (double)b;
            Console.WriteLine(quotient);

            int remainder = b % a;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978,1,1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan.Days);
        }
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 67;
            string username = "Doggo";
            bool equals = age == 41;
            bool userIsAdam = username == "Adam";
            Console.WriteLine("User is 41: " + equals);
            Console.WriteLine("User is Adam: " + userIsAdam);

            bool notEqual = age != 122;
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine($"User is not 122: {notEqual}");
            Console.WriteLine($"User is not Justin: {userIsNotJustin}");

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);
            secondList = firstList;
            bool listAreEqual = firstList == secondList;

            Console.WriteLine($"The lists are the same: {listAreEqual}");

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;
            bool lessThan = age < 68;
            bool lessThanOrEqual = age <= 67;

            bool orValue = equals || lessThan;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;
            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {fOrF}");

            bool tAndT = true && true;
            bool tAndF = true && false;
            bool fAndT = false && true;
            bool fAndF = false && false;
            Console.WriteLine($"True and True:  {tAndT}");
            Console.WriteLine($"True and false:  {tAndF}");
            Console.WriteLine($"False and True:  {fAndT}");
            Console.WriteLine($"False and False:  {fAndF}");

        }
    }
}
