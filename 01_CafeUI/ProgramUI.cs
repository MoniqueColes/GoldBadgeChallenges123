using _01_Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeUI
{
    public class ProgramUI


    {
        public readonly MenuRepo _menuRepo = new MenuRepo();
        public ProgramUI() { }
        public void RunMenu()
        {
            bool keepRunning = true;
            SeedContent();

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number from the selection below. \n" +
                    "1. Show Menu \n" +
                    "2. Add To Menu \n" +
                    "3. Delete From Menu \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        ShowAllContent();
                        break;
                    case "2":
                        //add new
                        AddToContent();
                        break;
                    case "3":
                        //delete
                        DeleteContent();
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

       
        public void ShowAllContent()
        {
            Console.Clear();
            //GET the items from our fake database 
            List<MenuContent> listOfContent = _menuRepo.GetContents();
            //Take EACH item and display property values
            foreach (MenuContent content in listOfContent)
            {
                Console.WriteLine($"{content.Number} \n" +
                $"{content.Name} \n" +
                $"{content.Description} \n" +
                $"Ingredients: {content.Ingredients}\n" +
                $"${content.Price}\n" +
                $"-----------------------");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        private void AddToContent()
            //add to menu
        {
            Console.Clear();
            // a new content object 
            MenuContent content = new MenuContent();
            //user input
            //menu number
            Console.WriteLine("Please enter the number of the menu item.");
            string contentNumber = Console.ReadLine();
            content.Number = contentNumber;
            Console.WriteLine($"Please enter the name of the menu item for {content.Number}");
            //name
            string contentName = Console.ReadLine();
            content.Name = contentName;
            //description
            Console.WriteLine($"Please enter the description for {content.Number}");
            string contentDescription = Console.ReadLine();
            content.Description = contentDescription;
            //ingredients
            Console.WriteLine($"Please enter the ingredients for {content.Number}");
            string contentIngredients = Console.ReadLine();
            content.Ingredients = contentIngredients;
            //price
            Console.WriteLine($"Please enter the price for {content.Number}");
            double contentPrice = Convert.ToDouble(Console.ReadLine());
            content.Price = contentPrice;
            //add item 
            if (_menuRepo.AddContentToRepo(content))
            {
                Console.WriteLine($"Item added.");
            }
            else
            {
                Console.WriteLine("Added item failed.");
            }

            //a new content with properties filled out by user 
            //Pass that to the add method in our repo 
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        //delete from menu
        private void DeleteContent()
        {
            //Ask the user which one they want to remove 
            Console.WriteLine("Which item would you like to remove?");
            //need a list of the items 
            List<MenuContent> contentList = _menuRepo.GetContents();
            int count = 0;
            foreach (var content in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {content.Name}");
            }
            //take in user response 
            int targetContentID = int.Parse(Console.ReadLine());
            int correctIndex = targetContentID - 1;
            if (correctIndex >= 0 && correctIndex < contentList.Count)
            {
                MenuContent SelectedContent = contentList[correctIndex];
                //Remove that item 
                if (_menuRepo.DeleteExistingContent(SelectedContent))
                {
                    Console.WriteLine($"Item deleted.");
                }
                else
                {
                    Console.WriteLine("Delete failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        private void SeedContent()
        {
            MenuContent _dishObject = new MenuContent("#1", "Sesame Chicken", "Chicken in sesame sauce with vegetables.", "chicken, sesame sauce, broccoli, carrots, water chestnuts", 8.95);
            _menuRepo.AddContentToRepo(_dishObject);
            MenuContent _dishObject2 = new MenuContent("#2", "Beef Lo Mein", "Beef and noodles with vegetables.", "beef, lo mein sauce, broccoli, carrots, water chestnuts", 9.95);
            _menuRepo.AddContentToRepo(_dishObject2);
        }

    }
}
