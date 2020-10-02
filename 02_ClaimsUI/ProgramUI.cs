using _02_Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsUI
{
    public class ProgramUI

    {
        public readonly ClaimProperties _claimProperties = new ClaimProperties();
        public ProgramUI() { }
        public void RunMenu()
        {
            bool keepRunning = true;
            SeedContent();

            while (keepRunning)
            {
                public ClaimProperties(int claimID, string claimType, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
                Console.Clear();
                Console.WriteLine("Please enter a number from the selection below. \n" +
                    "1. See all claims \n" +
                    "2. Take care of next claim \n" +
                    "3. Enter a new claim \n" +
                    "4. Exit");



                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all claims
                        ShowAllClaims();
                        break;
                    case "2":
                        //show next claim
                        ShowNextClaim();
                        break;
                    case "3":
                        //add new claim
                        AddToClaim();
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


        public void ShowAllClaims()
        {
            Console.Clear();
            //GET the items
            List<ClaimProperties> listOfContent = _claimMethods.GetClaims();
            //Take EACH item and display property values
            foreach (ClaimProperties content in listOfContent)
            {
                Console.WriteLine($"#{content.ClaimID} \n" +
                $"{content.ClaimType} \n" +
                $"{content.Description} \n" +
                $"${content.ClaimAmount}\n" +
                $"{content.DateOfIncident}\n" +
                $"{content.DateOfClaim}\n" +
                $"{content.IsValid}\n" +
                $"-----------------------");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }




        //show next claim
        public void ShowNextClaim()
        {
            Console.Clear();
            for (int claimID = 1; claimID <= endNumber; claimID++1)
            {
                if (     )
                {


                }


            }



        }














        private void AddToClaim()
        //add a claim
        {
            Console.Clear();
            //new claim content 
            ClaimProperties content = new ClaimProperties();
            //user input
            //claim ID
            Console.WriteLine("Please enter the claim ID.");
            string contentClaimID = Console.ReadLine();
            content.ClaimID = contentClaimID;
            //claim type
            Console.WriteLine($"Please enter the claim type for {content.ClaimID}");
            string contentName = Console.ReadLine();
            content.ClaimType = contentClaimType;
            //claim description
            Console.WriteLine($"Please enter the description for {content.ClaimID}");
            string contentDescription = Console.ReadLine();
            content.Description = contentDescription;
            //claim amount
            Console.WriteLine($"Please enter the claim amount for {content.ClaimID}");
            string contentClaimAmount = Console.ReadLine();
            content.ClaimAmount = contentClaimAmount;
            //date of incident
            Console.WriteLine($"Please enter the date of incident for {content.ClaimID}");
            DateTime.DateOfIncident = Convert.ToString(Console.ReadLine());
            content.DateOfIncident = contentDateOfIncident;
            //date of claim
            Console.WriteLine($"Please enter the date of claim for {content.ClaimID}");
            DateTime.DateOfClaim = Convert.ToString(Console.ReadLine());
            content.DateOfClaim = contentDateOfClaim;
            //is valid
            //Console.WriteLine($"Please enter the date of incident for {content.ClaimID}");
            //DateTime.DateOfIncident = Convert.ToString(Console.ReadLine());
            //content.DateOfIncident = contentDateOfIncident;
            //add item 
            if (_claimMethods.AddContentToMethods(content))
            {
                Console.WriteLine($"Item(s) added.");
            }
            else
            {
                Console.WriteLine("Added item(s) failed.");
            }

            //a new content with properties filled out by user 
            //Pass that to the add method in our methods 
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public void SeedContent()
        {

            ClaimProperties _claimObject = new ClaimProperties(1, "Car", "Car Accident on 465.", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));

            ClaimProperties _claimObject2 = new ClaimProperties(2, "Home", "House fire in kitchen.", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));

            ClaimProperties _claimObject3 = new ClaimProperties(3, "Theft", "Stolen pancakes.", 4.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01));

        }
    }
}
