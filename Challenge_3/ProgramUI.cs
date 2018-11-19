using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingRepository _outingRepo = new OutingRepository(); //field

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1.Display a list of all outings" +
                    "\n2. Add individual outings to a list" +
                    "\n3. Calculations: ");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        ListOutings(); 
                        break;
                    case 2:
                        AddOutings();
                        break;
                    case 3:
                        CalculationMenu();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Seeya later, fam");
                        break;
                    default:
                        Console.WriteLine("oh no bb what is u doin?");
                        break;
                }
            }
        }
        private void ListOutings()
        {
            List<OutingContent> outingContents = _outingRepo.ShowAllOutings();
            foreach (OutingContent outing in outingContents)
            {
                Console.WriteLine(outing.OutingType);
                Console.WriteLine(outing.NumOfPeople);
                Console.WriteLine(outing.Date);
                Console.WriteLine(outing.TotalPerPerson);
                Console.WriteLine(outing.TotalForEvent);

            }

        }

        private void AddOutings()
        {
            OutingContent newOuting = new OutingContent();
            Console.WriteLine("What type of outing is it?");
            newOuting.OutingType = Console.ReadLine();

            Console.WriteLine("How many people attended?");
            newOuting.NumOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the date?");
            newOuting.Date = Console.ReadLine();

            Console.WriteLine("Total cost per person for the event?");
            newOuting.TotalPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Total cost for the event?");
            newOuting.TotalForEvent = decimal.Parse(Console.ReadLine());

            _outingRepo.AddOutingToList(newOuting);
        }

        private decimal CalculationMenu()
        {
            List<OutingContent> outingContents = _outingRepo.ShowAllOutings();
            Console.WriteLine("1. Display TOTAL cost of all outings" +
                "\n2. Display cost by type" +
                "\n3. Return to main menu");

            int input = int.Parse(Console.ReadLine());
            decimal balance = 0;
            switch (input)
            {
                case 1:
                    //add all costs
                    
                    
                    foreach (OutingContent content in outingContents)
                    {
                        balance += content.TotalForEvent ;
                        Console.WriteLine($"the Total Cost is {balance}");
                    }
                    break;
                    
                    //int balance = outingContents.Select
                case 2: //find a way to pull out all the costs . do some type of conditional if this property type
                    Console.WriteLine("write the type");
                    string userInput = Console.ReadLine(); //i want to have this user input to be equal to what it returns

                    foreach (OutingContent content in outingContents)
                    {

                        if (content.OutingType == userInput)
                        {
                            balance += content.TotalForEvent;
                            Console.WriteLine($"the balance is {balance}");
                        }
                        else
                        {
                            Console.WriteLine("oh no bb what is u doin?");
                        }
                    }
                    break;
                    
                case 3:
                    break;
            }
            return balance; 
        }
    }
}
