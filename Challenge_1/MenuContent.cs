using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuContent
    {
        //properties of the menu items
        public int MealNum { get; set;  }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public double MealPrice { get; set; }

        public MenuContent(int mealNum, string mealName, string mealDescription, string mealIngredients, double mealPrice)
        {
            MealNum = mealNum;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealDescription;
            MealPrice = mealPrice;
        }

        public MenuContent()
        {

        }
    }

    
}
