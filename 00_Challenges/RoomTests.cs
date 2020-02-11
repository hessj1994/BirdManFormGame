using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void CheckSquareFootage()
        {
            Room classroom = new Room();
            classroom.Length = 10;
            classroom.Width = 10;

            double squareFootage = classroom.CalculateSquareFootage();

            Console.WriteLine($"Actual Square Footage: {squareFootage}");

            Assert.AreEqual(100, squareFootage);
        }

        [TestMethod]
        public void CheckSquareFootageFraction()
        {
            Room classroom = new Room
            {
                Length = 10,
                Width = 10
            };

            int denominator = 0;

            double actual = classroom.CalculateSquareFootage(denominator);
            double expected = classroom.Length * classroom.Width / denominator;

            Assert.AreEqual(expected, actual);
        }
    }
}
