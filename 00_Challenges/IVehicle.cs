using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    //NAMING CONVENNTION FOR INTERFACES I I I I I I I I I
    //making an interface, multiple vehicles with attributes and actions, classes and methods
    //dont necessarily need a vehicle class
    //properties make, model, and color, objects. Methods, start, turn off, and drive, actions, process that must be done
    //props define current status, methods modify the status
    //ex putting color changing in vehicle class, is it the cars responsibility? no, would need a bodyshop method ex.
    //how to define a property inside an interface? 
    interface IVehicle
    {
        string Make { get; set; }//open up the get or no?
        string Model { get; set; }
        string Color { get; set; }
        //inside an interface, not allowed to have access modifier
        //what happens if we call start whhen the car is already running? solution?
        bool IsRunning { get; set; }//if want to change with a method need to include the set
      //void Start(); //come back and add key param? vehicle may not have same type of start param,
        //might not be best to set it in interface... bool return false, car willl not start, is already runnign --> bool IsRunning,
        //not relvant as long as long as calling start returns true
        //if running, take away ability of car to start or your abiility to start it.  display turnoff or start depending on boolean true or false
      //void TurnOff();
        void Drive();//could return void, or make prop isRunning will change, string --> void
    }
}
