using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class ProgramUI
    {
        CafeRepository _contentRepo = new CafeRepository(); //created a field
        List<MenuContent> _listOfContent;

        public void Run()//while loop for menu
        {
            _listOfContent = _contentRepo.GetMenuContent();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Cafe Main Menu v.1.0" +
                    "\n1. Add a Meal" +
                    "\n2. Remove a Meal" +
                    "\n3. See current Menu" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: //method will create a meal, and add it to list
                        CreateMeal();
                        break;
                    case 2:
                        RemoveMeal();
                        break;
                    case 3:
                        ShowList();
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
        private void CreateMeal()
        {
            MenuContent newContent = new MenuContent(); // blank slate - give it values
            Console.WriteLine("What is the meal number?");
            newContent.MealNum = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the meal name?");
            newContent.MealName = Console.ReadLine();

            Console.WriteLine("Please provide a description of the meal");
            newContent.MealDescription = Console.ReadLine();

            Console.WriteLine("What are the ingredients?");
            newContent.MealIngredients = Console.ReadLine();

            Console.WriteLine("What is the price?");
            newContent.MealPrice = int.Parse(Console.ReadLine());

            _contentRepo.AddContentToList(newContent);
        }

        private void RemoveMeal()
        {
            Console.WriteLine("What item would you like to remove?");
            //they need to see the list, make a foreach . boolean inside foreach . for every meal called "" remove it.
            var MealNumber = int.Parse(Console.ReadLine()); //type, saved to item, 

            foreach (MenuContent content in _listOfContent.ToList()) //for each int
            {
                if (content.MealNum == MealNumber) //MealNumber is expected value, content.MealNum is OBJECT. trying to get to OBJECT property 
                {
                    _contentRepo.RemoveContent(content); //this is my instance of repository. call repository method to remove. I already declared MenuContent
                }
            }
            return;
        }

        private void ShowList()
        {
            List<MenuContent> contentList = _contentRepo.GetMenuContent();
            foreach (MenuContent content in contentList)
            {
                Console.WriteLine(content.MealNum);
                Console.WriteLine(content.MealName);
                Console.WriteLine(content.MealDescription);
                Console.WriteLine(content.MealIngredients);
                Console.WriteLine(content.MealDescription);
            }
        }
    }
}

