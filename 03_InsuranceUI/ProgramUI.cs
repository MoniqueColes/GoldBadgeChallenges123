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
                        AddABadge();
                        break;
                    case "2":
                        //edit a badge
                        EditABadge();
                        break;
                    case "3":
                        //list all badges
                        ListAllBadges();
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


        public void AddABadge()
        //add a badge
        {
            Console.Clear();
            //user input
            //badge ID
            Console.WriteLine("Please enter the number on the badge:");
            int BadgeID = Int32.Parse(Console.ReadLine());
            //door type
            Console.WriteLine($"Please enter the door that the badge needs access to:");
            string Door = Console.ReadLine();
            //more doors
            Console.WriteLine($"Any other doors? (y/n)");
            string moreDoors = Console.ReadLine();
            while (moreDoors == "y")
            {
                Console.WriteLine($"Please enter the door that the badge needs access to:");
                string NextDoor = Console.ReadLine();
                Door = Door + ", " + NextDoor;
                Console.WriteLine($"Any other doors? (y/n)");
                moreDoors = Console.ReadLine();
            }
            _badgeMethods.DoorList.Add(BadgeID, Door);
            
            //add item 
           // if (_badgeMethods.AddContentToMethods(content))
            //{
              //  Console.WriteLine($"Badge added.");
            //}
            //else
            //{
              //  Console.WriteLine("Add badge failed.");
            //}

            //a new content with properties filled out by user 
            //Pass that to the add method in our methods 
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }



        public void ListAllBadges()
        {
            Console.Clear();
            //display badges and doors
            foreach (KeyValuePair<int, string> badgeID in _badgeMethods.DoorList)
            {
                Console.WriteLine($"BadgeID: {badgeID.Key}, Door Access: {badgeID.Value} \n" +
                    $"-------------------");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public void EditContentByBadgeID()
        {
            Console.Clear();
            Console.WriteLine(BadgeID);

            Console.WriteLine("What is the badge number to update?");
            string myinput = Int32.Parse(doorBadgeID);
                Console.ReadLine();
            Console.WriteLine("{BadgeID} has access to doors { });






        }



        public void SeedContent()
        {
            _badgeMethods.DoorList.Add(12345, "A7");
            _badgeMethods.DoorList.Add(22345, "A1, A4, B1, B2");
            _badgeMethods.DoorList.Add(32345, "A4, A5");
        }


    }
}
