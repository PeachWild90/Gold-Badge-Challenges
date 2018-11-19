using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class TestClassUI
    {
        ClaimRepository _claimRepo = new ClaimRepository(); //field

        Queue<ClaimContent> _claimsQueue = new Queue<ClaimContent>();

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu item:" +
                    "\n1. See all claims" +
                    "\n2. Take care of the next claim" +
                    "\n3. Enter a new claim" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        ListToDataTable();
                        break;
                    case 2:
                        NextTable();
                        break;
                    case 3:
                        CreateClaim();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Goodbye, fam");
                        break;
                    default:
                        Console.WriteLine("ruh roh");
                        break;
                }
            }
        }
        private void ListToDataTable()
        {
            Queue<ClaimContent> contentList = _claimRepo.GetClaims();
            var ID = "ClaimID";
            var Type = "Type";
            var Description = "Description";
            var Amount = "Amount";
            var DateOfAccident = "DateOfAccident";
            var DateOfClaim = "DateOfClaim";
            var IsValid = "IsValid";
            Console.WriteLine($"{ID,-15} {Type,-15} {Description,-15} " +
                $"{Amount,-15} {DateOfAccident,-25} {DateOfClaim,-25} {IsValid,-15}");
            foreach (var content in contentList)
            {
                Console.WriteLine($"{content.ClaimID,-15} {content.Type,-15} {content.Description,-15} {content.Amount,-15} " +
                    $"{content.DateOfAccident,-25} {content.DateOfClaim,-25} {content.IsValid,-15}");
            }
        }
        private void NextTable()
        {
            Console.WriteLine("Here are the details for the next claim to be handled: ");
            
            ClaimContent claimContent = _claimRepo.SeeContent();

            Console.WriteLine($"ClaimID: {claimContent.ClaimID}");
            Console.WriteLine($"Type: {claimContent.Type}");
            Console.WriteLine($"Description: {claimContent.Description}");
            Console.WriteLine($"Amount: {claimContent.Amount}");
            Console.WriteLine($"DateOfAccident: {claimContent.DateOfAccident}");
            Console.WriteLine($"DateOfClaim: {claimContent.DateOfClaim}");
            Console.WriteLine($"IsValid: {claimContent.IsValid}");
            
        }

        private void CreateClaim()
        {
            ClaimContent newClaim = new ClaimContent();
            Console.WriteLine("Enter the claim id:  ");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of accident: ");
            newClaim.DateOfAccident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the date of the claim: ");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount: ");
            newClaim.Amount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What is the type: (Car, Home, Theft)");
            newClaim.Type = Console.ReadLine();

            Console.WriteLine("Provide a description: ");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Is this claim valid? (y/n)");
            newClaim.IsValid = IsItValid();

            _claimRepo.AddClaimsToQueue(newClaim);

        }
        private bool IsItValid()
        {
            var customerInput = Console.ReadLine();
            if (customerInput == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}


