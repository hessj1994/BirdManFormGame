using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.CustomerCarInsurance
{
    /*
    store and manipulate our customers => Customer Repository

    send a message to customers based on their years of subscribing => Repository Method
        If they’ve been part of a plan for 1-5 years, we send them a thank you note.
        If they have been a customer for more than 5 years, we send them a note that says: “Thank you for being a Gold member.”
    */
    public class CustomerRepository
    {
        private List<Customer> _customerList = new List<Customer>();

        public void AddCustomerToList(Customer newCustomer)
        {
            _customerList.Add(newCustomer);
        }

        public string GetThankYou(Customer customer)
        {
            if (customer.YearsAsCustomer <= 5)
            {
                return "Thank you for being a valued customer.";
            }
            else
            {
                return "Thank you for being a Gold member.";
            }
        }
    }
}
