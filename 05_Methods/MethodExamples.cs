using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //1      2       3
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public int Add(int numOne, int numTwo,int another)
        {
            return numOne + numTwo + another;
        }

        public double Add(double numberOne, double numberTwo)
        {
            double sum = numberOne + numberTwo;
            return sum;
        }
        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYear = ageSpan.TotalDays / 365.25;
            double floorAge = Math.Floor(totalAgeInYear);
            int years = Convert.ToInt32(floorAge);
            //int years = Convert.ToInt32(Math.Floor(totalAgeInYear));
            return years;
        }

        [TestMethod]
        public void MethodExecution()
        {
            SayHello("George");
            SayHello("Josh");

            int total = Add(23,86);
            Console.WriteLine(total);
            var another = Add(1,6);
            DateTime birthdate = new DateTime(1944, 12, 24);
            Console.WriteLine(CalculateAge(birthdate));
            
        }
    }
}
