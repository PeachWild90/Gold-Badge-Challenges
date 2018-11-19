using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class BadgeRepository
    {
        Dictionary<int, List<string>> badgeDictionary = new Dictionary<int, List<string>>();

        public void AddBadgeToDictionary(int badge, List<string> doorList)
        {
            badgeDictionary.Add(badge, doorList); //im adding a badge with a key/ID, and a list of access doors
        }

        public Dictionary<int, List<string>> GetBadgeDictionary() //show badge list
        {
            return badgeDictionary;    
        }

        public void RemoveAllDoorsFromBadge(int key) //remove all doors, key, creates a "masterList"
        {
            badgeDictionary.Remove(key); 
        }

       public BadgeRepository()
        {

        }
    }
}

