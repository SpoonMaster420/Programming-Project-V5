using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_V5
{
    public class Customer
    {
        //Holds the ID, Firstname, Lastname, Email and Phone number of the customer
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //Initialises the properties of the customer object
        public Customer(int id, string firstname, string lastname, string email, string phone)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
        }

        public override string ToString() //this is here so the customer's ID, Firstname, Lastname and email is shown instead of the object name
        {
            return ID + " " + FirstName + " " + LastName + " " + Email;
        }

    }
}
