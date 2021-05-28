using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP2.Models
{
    class Lab3class
    {
      
        private string contact;
        private string customer;
        private string email;

        public Lab3class(string contact, string customer, string email)
        {
            Contact = contact;
            Customer = customer;
            Email = email;
        }

        public string Contact { get => contact; set => contact = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Email { get => email; set => email = value; }
    }
}
