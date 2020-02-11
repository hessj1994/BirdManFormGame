using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_KI_Vehicles
{
    // Can the program be set as a unit test initially and run the entire code in one project?

    //    creating methods that use all of their different types of vehicles.
    //Before that can be done, they need to make an interface that can be implemented on all of their classes.
    //KI has all of their vehicle types (sedans, SUV, motorcycle, etc) sharing similar attributes and actions. All vehicles need to be able to start, turn off, drive, as well as they all have a make, model, and color.
    //To demonstrate the benefits, make the interface and a few example classes. Write a few tests as well showing the power of the new interface.
    public enum VehicleType { Sedan, SUV, Motorcycle }
    public class Vehicles
    {
        public string vehicleType { get; set; }
        //public string suvs
        //{
        //    get 
        //}
        //public string motorcycles { get; set; }
        public bool startVehicle = true;
        public bool turnOffVehicle = true;
        public bool isDriving = true;

    }
}
