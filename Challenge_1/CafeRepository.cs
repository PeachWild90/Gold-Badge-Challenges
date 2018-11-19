using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1 
{
    class CafeRepository //hide methods here, make a list to keep track of all the meals
    {
        List<MenuContent> _listOfContent = new List<MenuContent>(); //Delcared field

        public void AddContentToList(MenuContent content)
        {
            _listOfContent.Add(content); //passing in parameter ie content
        }

        public List<MenuContent> GetMenuContent()
        {
            return _listOfContent; //doorway for UI to package/retrieve list
        }

        public void RemoveContent(MenuContent content)
        {
            _listOfContent.Remove(content);
        }
        public CafeRepository()
        {

        }
    }
    
}
