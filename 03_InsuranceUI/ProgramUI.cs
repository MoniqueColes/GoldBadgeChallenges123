using _03_InsuranceBadge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InsuranceUI
{
    class ProgramUI
    {
        private Dictionary<int, List<string>> _doorList = new Dictionary<int, List<string>>();
        public readonly BadgeMethods _badgeMethods = new BadgeMethods();
        public ProgramUI() { }
        public void RunMenu()
        {
            bool keepRunning = true;
            SeedContent();

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin. What would you like to do? \n" +
                    "1. Add a badge \n" +
                    "2. Edit a badge \n" +
                    "3. List all badges \n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //add a badge
                        AddNewBadgeUI();
                        break;
                    case "2":
                        //edit a badge
                        EditDoorAccessByBadgeIDUI();
                        break;
                    case "3":
                        //list all badges
                        ListAllBadgesUI();
                        break;
                    case "4":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        //default
                        Console.WriteLine("Please enter a valid number of 1 through 4. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void AddNewBadgeUI()
        //add a badge
        {
            Console.Clear();
            Console.WriteLine("Please enter badgeID to add a door:");
            int keyBadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter the first door.");
            List<string> valueBadgeID = new List<string>();
            valueBadgeID.Add(Console.ReadLine());

                bool addNextDoor = true;
                while (addNextDoor)
                {

                    Console.WriteLine("Add another Door? (y/n)");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "y":
                            {
                                Console.WriteLine("Please enter door to be added:");
                                string doorNumber = Console.ReadLine();
                                valueBadgeID.Add(doorNumber);
                                break;
                            }
                        case "n":
                            {
                                addNextDoor = false;
                                break;
                            }

                        default:
                            {
                                addNextDoor = false;
                                break;
                            }
                    }
                }
                _badgeMethods.AddNewBadge(keyBadgeID, valueBadgeID);

            //a new content with properties filled out by user 
            //Pass that to the add method in our methods 
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public void ListAllBadgesUI()
        {
            Console.Clear();
            //display badges and doors
            foreach (KeyValuePair<int, List<string>> badgeID in _doorList)
            {
                Console.WriteLine($"BadgeID: {badgeID.Key}, Door Access: \n");
                //Take each badge and display door values
                foreach (string door in badgeID.Value)
                {
                    Console.WriteLine($"{door} \n");
                }

            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public void EditDoorAccessByBadgeIDUI()
        {
            Console.Clear();
            Console.WriteLine("Please enter the badge number to be updated:");
            int BadgeID = Int32.Parse(Console.ReadLine());
            //door access
            Console.WriteLine($"{BadgeID} has access to doors {_doorList}.");
            Console.WriteLine("What would you like to do? \n" +
                "1. Add a door \n" +
                "2. Remove a door \n");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AddADoorUI();
                    break;
                case "2":
                    RemoveADoorUI();
                    break;
            }
        }

        public void AddADoorUI()
        {
            Console.WriteLine("Please enter badgeID to add a door:");
            int keyBadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter the first door.");
            List<string> valueBadgeID = new List<string>();
            valueBadgeID.Add(Console.ReadLine());

            bool addNextDoor = true;
            while (addNextDoor)
            {

                Console.WriteLine("Add another Door? (y/n)");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "y":
                        {
                            Console.WriteLine("Please enter door to be added:");
                            string doorNumber = Console.ReadLine();
                            valueBadgeID.Add(doorNumber);
                            break;
                        }
                    case "n":
                        {
                            addNextDoor = false;
                            break;
                        }

                    default:
                        {
                            addNextDoor = false;
                            break;
                        }
                }
            }
            _badgeMethods.AddNewBadge(keyBadgeID, valueBadgeID);
        }

        public void RemoveADoorUI()
        {
            Console.WriteLine("Please enter badgeID to add a door:");
            int keyBadgeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Which door access would you like to remove?");
            _doorList[keyBadgeID].Remove(Console.ReadLine());
        }

        public void SeedContent()
        {
            _doorList.Add(12345, new List<string> { "A7" });
            _doorList.Add(22345, new List<string> { "A1", "A4", "B1", "B2"});
            _doorList.Add(32345, new List<string> { "5" });
        }
    }
}
