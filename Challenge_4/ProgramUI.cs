using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class ProgramUI
    {
        BadgeRepository _badgeRepository = new BadgeRepository();
        Dictionary<int, List<string>> badgeDictionary;

        public void Run()
        {
            badgeDictionary = _badgeRepository.GetBadgeDictionary();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome. What would you like to do?" +
                    "\n1. Create Badge" +
                    "\n2. Update Door Clearance on a Badge" +
                    "\n3. Delete all doors from a Badge" +
                    "\n4. Show List of All Badges");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateBadge();
                        break;
                    case 2:
                        UpdateClearance();
                        break;
                    case 3:
                        DeleteDoors();
                        break;
                    case 4:
                        ShowDoorList();
                        break;
                }
            }
        }
        private void CreateBadge()
        {
            Badge newBadge = new Badge();
            List<string> listOfDoors = new List<string>();//instantiating a list, it's null, but new af
            Console.WriteLine("Please enter the BadgeID");
            newBadge.BadgeID = int.Parse(Console.ReadLine());
            
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.WriteLine("Please enter the door access");
                string input = Console.ReadLine();
                listOfDoors.Add(input); //every time im hittin the list, its adding user input right on top
                
                Console.WriteLine("Would you like to add more?(y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        isRunning = true;
                    }
                    else
                    {
                        isRunning = false;
                    }
             }
            newBadge.DoorList = listOfDoors;
            _badgeRepository.AddBadgeToDictionary(newBadge.BadgeID, newBadge.DoorList);

        }

        private void UpdateClearance()
        {
            Badge newBadge = new Badge();
            Dictionary<int, List<string>> badgeUser = _badgeRepository.GetBadgeDictionary();
            List<string> listOfDoors = new List<string>();

            Console.WriteLine("Please enter the ID");
            var BadgeID = int.Parse(Console.ReadLine());
            
            foreach(var badge in badgeUser)
            {
                bool isRunning = true;
                while (isRunning == true)
                {
                    if (badge.Key == BadgeID)
                    {
                        Console.WriteLine("Please enter the door access");
                        string input = Console.ReadLine();
                        listOfDoors.Add(input);

                        Console.WriteLine("Would you like to add more?(y/n)");
                        if (Console.ReadLine() == "y")
                        {
                            isRunning = true;
                        }
                        else
                        {
                            isRunning = false;
                        }
                    }
                }
            }
            newBadge.DoorList = listOfDoors;
            _badgeRepository.AddBadgeToDictionary(newBadge.BadgeID, newBadge.DoorList);
        }

        private void DeleteDoors()
        {
            Console.WriteLine("Please enter the ID");
            var BadgeID = int.Parse(Console.ReadLine());

            foreach(var badge in badgeDictionary.ToList())
            {
                if (badge.Key == BadgeID)
                {
                    _badgeRepository.RemoveAllDoorsFromBadge(BadgeID); //address
                }
            }
            return;
        }

        private void ShowDoorList()
        {
            var ID = "Badge #";
            var Access = "Door Access";

            Dictionary<int, List<string>> userList = _badgeRepository.GetBadgeDictionary();
            Console.WriteLine("Key" +
                    $"\n{ID,-15} {Access,-15}");
            foreach (var badge in userList)
            {
                Console.Write($"{badge.Key,-15},");
                    foreach(string s in badge.Value)
                {
                    Console.WriteLine($"{s,-15}");
                }
            }
        }
    }
}
