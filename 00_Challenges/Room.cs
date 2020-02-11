using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    /*Create a Room class that has three properties:
        one each for the length, width, and height.
      Create a method that calculates total square footage.

      Bonus:
      Create a method that calculates total lateral surface area.
      Only allow the properties to be set from inside the class itself.*/

    class Room
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }


        public double CalculateSquareFootage()
        {
            double squareFootage = Length * Width;
            return squareFootage;
        }

        public double CalculateSquareFootage(int denominator)
        {
            double squareFootage = Length * Width;
            double targetSquareFootage = squareFootage / denominator;
            return targetSquareFootage;
        }

        public double CalculateLateralSurfaceArea()
        {
            double lengthLSA = Length * Height * 2;
            double widthLSA = Width * Height * 2;
            double totalLSA = lengthLSA + widthLSA;
            return totalLSA;
        }
    }
}
