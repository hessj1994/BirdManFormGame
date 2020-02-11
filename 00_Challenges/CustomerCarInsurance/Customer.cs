using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.CustomerCarInsurance
{
    /*
    program to track their customers => 
    Customer
        a unique customer id number,
        last name,
        age,
        enrollment date,
        number of years using Komodo Insurance.

    store and manipulate our customers => Customer Repository

    KI also requires that any methods built are unit tested.

    send a message to customers based on their years of subscribing => Repository Method
        If they’ve been part of a plan for 1-5 years, we send them a thank you note.
        If they have been a customer for more than 5 years, we send them a note that says: “Thank you for being a Gold member.”

    Write unit tests to ensure your methods are working properly and use the repository pattern.
    */

    public class Customer
    {
        //a unique customer id number,
        //last name,
        //age,
        //enrollment date,
        //number of years using Komodo Insurance.
        public string CustomerID { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int YearsAsCustomer
        {
            get
            {
                double totalTime = (DateTime.Now - EnrollmentDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        }
    }
}
