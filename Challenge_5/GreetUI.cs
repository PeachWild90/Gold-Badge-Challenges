using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class GreetUI
    {
        CustomerRepository _customerInfoRepo = new CustomerRepository(); //create a field
        List<CustomerInfo> _customers; //declared the list herr
        public void Run()
        {
            _customers = _customerInfoRepo.GetCustomerList(); //now we have access to the list, so define it
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Greetings, Skillet" +
                    "\n1. Create a Customer " +
                    "\n2. See Individual Customer" +
                    "\n3. Delete Customer " +
                    "\n4. Update Customer " +
                    "\n5. Show List of All Customers " +
                    "\n6. Exit this hizzle");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        CreateCustomer();
                        break;
                    case 2:
                        PrintIndividualCustomer();
                        break;
                    case 3:
                        DeleteCustomer();
                        break;
                    case 4:
                        UpdateCustomer();
                        break;
                    case 5:
                        ShowAllCustomerList();
                        break;
                }
            }
        }
        private void CreateCustomer()
        {
            CustomerInfo newCustomer = new CustomerInfo();

            Console.WriteLine("What is the First Name?");
            newCustomer.FirstName = Console.ReadLine();

            Console.WriteLine("What is the Last Name?");
            newCustomer.LastName = Console.ReadLine();

            Console.WriteLine("What type of customer are we dealing with?");
            newCustomer.TypeOfCustomer = DefineCustomerType();

            Console.WriteLine("They will recieve the following email: ");
            newCustomer.Email = DefineEmailType(newCustomer.TypeOfCustomer); //i have to pass newcustomer.typeofcustomer through this method in order to access the information. otherwise it doesnt know what the deal is

            _customerInfoRepo.AddCutomerToList(newCustomer);

        }

        private CustomerType DefineCustomerType()
        {
            Console.WriteLine("Please choose a customer type: Potential/Current/Past *case sensitive*");
            var customerInput = Console.ReadLine();

            switch (customerInput)
            {
                case "Potential":
                    return CustomerType.Potential;

                case "Current":
                    return CustomerType.Current;

                default:
                    return CustomerType.Past; //no breaks, bc return does SPECIFIC SHIT and BREAKS u out
            }

        
        }
        private void UpdateCustomer()
        {
            Console.WriteLine("please enter their first name: ");
            string userInput = Console.ReadLine();

            foreach (CustomerInfo customer in _customers) //adding _customers sets equal to the list/repository think quantum intanglement. WE NEED TO GET OUT LISTS/REPOSITORIES IN ORDER AT TOP AND INSIDE OUR RUN METHOD 
            {
                if (customer.FirstName == userInput)
                {
                    CreateCustomer();
                }
            }
        }

        private void PrintIndividualCustomer()
        {
            Console.WriteLine("please enter their first name: ");
            string userInput = Console.ReadLine();

            foreach (CustomerInfo customer in _customers) //adding _customers sets equal to the list/repository think quantum intanglement. WE NEED TO GET OUT LISTS/REPOSITORIES IN ORDER AT TOP AND INSIDE OUR RUN METHOD 
            {
                if (customer.FirstName == userInput)
                {
                    Console.WriteLine(customer.FirstName);
                    Console.WriteLine(customer.LastName);
                    Console.WriteLine(customer.TypeOfCustomer);
                    Console.WriteLine(customer.Email);
                }
            }
        }
        private void DeleteCustomer()
        {
            Console.WriteLine("please enter their first name: ");
            string userInput = Console.ReadLine();

            foreach (CustomerInfo customer in _customers.ToList())
            {
                if (customer.FirstName == userInput)
                {
                    _customerInfoRepo.RemoveCustomerInfo(customer);
                }
            }
            return;
        }
        private void ShowAllCustomerList() //firstname lastnape tpye email
        {
            _customerInfoRepo.SortList();
            var FirstName = "FirstName";
            var LastName = "LastName";
            var Type = "Type";
            var Email = "Email";

            List<CustomerInfo> customerList = _customerInfoRepo.GetCustomerList();
            Console.WriteLine($"{FirstName, -15} {LastName, -15} {Type, -15} {Email, -15}");
            foreach(var customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName, -15} {customer.LastName, -15} " +
                    $" {customer.TypeOfCustomer, -15} {customer.Email, -15}");
            }
        }
        private string DefineEmailType(CustomerType type) //pass in customertype so i have access. also define variable because itll forget it 
        { //type is placeholder for any CustomerType in this method
            switch (type)
            {
                case CustomerType.Potential:
                    return "We currently have the lowest rates on Helicopter Insurance!";
                    
                case CustomerType.Current:
                    return "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
                    
                case CustomerType.Past:
                    return "It's been a long time since we've heard from you, we want you back";

                default:
                    return "Bro you fudged it up...";
                
                    
            }
        }
    }
}

