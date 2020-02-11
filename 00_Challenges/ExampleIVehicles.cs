using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    class Sedan : IVehicle // first implementation, hover and will show lacking params
    {//not a specific type, just a sedan if ever wanted to include one etc
        public string Make { get; set; } //prop tabtab will add scaffolding with thrown exceptions, now just needs to work,
        //later on, if exceptions arise, ex. divide by zero, want to then handle exception instead of ex. breaking calc
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsRunning { get; set; }

        public void Drive()//if statement, dont want car to show driving if off
        {
            if (IsRunning)
            {
                Console.WriteLine("The vehicle starts driving.");//could add accelerate and brake methods, nothing happens if IsRunning is false
            }
            else
            {
                Console.WriteLine("The vehicle is off and cannot drive.");
            }//not returning anything, would run entire method and never exit early, requires the else, w/out would always output else cw
        }

        //public void Start()//turn vehicle on, isrunning to true
        //{//! = bangIsRunning, inverse of set attribute, in this case is false
        //    if (!IsRunning)
        //    {
        //        IsRunning = true;
        //        Console.WriteLine("The vehicle turns on.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The vehicle is running already.");
        //    }
        //}

        //public void TurnOff()//redunancy, combine in same method
        //{
        //    if (IsRunning)
        //    {
        //        IsRunning = false;
        //        Console.WriteLine("The vehicle turns off.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The vehicle is off already.");
        //    }
        //}

        public void ToggleIsRunning()
        {//check if off first bc will always be off when getting in, syntactical bs, irrelevant to the method
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("The car turns on.");
            }
            else//scope creep?
            {
                IsRunning = false;
                Console.WriteLine("The vehicle turns off.");
            }
        }
    }
}
