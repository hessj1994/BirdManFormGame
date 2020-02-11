using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;
            bool isDeclarationAndInitialized = true;
            // some notes
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '&';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;
        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.2578907289045789789789789787897f;
            double doubleExample = 1.2578907289045789789789789787897d;
            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake = 1, Danish, Doughnut, Scone, Cupcake, Croissant}
        
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Scone;
            Console.WriteLine(myPastry);
            Console.WriteLine(anotherOne);
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(2020, 11, 24);
            Console.WriteLine(birthday.ToShortDateString());
            
        }
        [TestMethod]
        public void Challenges()
        {
            /*Declare 5-10 variables
Initialize at least 5 of them. You cannot have more than 2 of any type. 
Bonus: If you finish that make an enum. 
Console Writeline all initialized values 
*/
        }
    }
}
