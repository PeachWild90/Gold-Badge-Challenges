using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
        public enum CustomerType { Potential = 1, Current = 2, Past = 3}
   public class CustomerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType TypeOfCustomer{ get; set; }
        public string Email { get; set; }

        public CustomerInfo(string firstName, string lastName, CustomerType typeOfCustomer, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = typeOfCustomer;
            Email = email;
        }

        public CustomerInfo()
        {

        }
    }
    
}
