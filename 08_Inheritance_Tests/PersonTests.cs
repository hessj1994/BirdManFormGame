using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetAddress()
        {
            Person martha = new Person();
            martha.Address.StreetName = "Fake Street";
            martha.Address.HouseNumber = "123";

            Console.WriteLine(martha.Address);

            Customer julie = new Customer();
            julie.Address.StreetName = "Fake Street";
            julie.Address.HouseNumber = "124";

            Console.WriteLine(julie.Address);
        }

        [TestMethod]
        public void CustomerIsPremium()
        {
            Customer kevin = new Customer();
            kevin.IsPremium = true;

            Console.WriteLine(kevin.IsPremium);
            Console.WriteLine(kevin.GetType());

            Assert.IsTrue(kevin.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            tony.HoursWorked = 12;
            tony.HourlyWage = 15000;
            SalaryEmployee friday = new SalaryEmployee();
            friday.Salary = 1000000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(friday);

            //var employee = allEmployees[1];
            
            foreach(Employee worker in allEmployees)
            {
                if (worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"This is a salary employee that makes {sEmployee.Salary}.");
                }
                else if (worker is HourlyEmployee hourlyWorker) // Pattern Matching
                {
                    // Casting
                    HourlyEmployee hEmployee = (HourlyEmployee)worker;
                    Console.WriteLine(hourlyWorker.HoursWorked);
                }
            }
        }
    }
}
