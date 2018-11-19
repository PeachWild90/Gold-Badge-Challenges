using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimContent
    {
        //properties of claims
        public int ClaimID { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsValid { get; set; }

        public ClaimContent(int claimID, DateTime dateOfAccident, DateTime dateOfClaim, decimal amount, string type, string description, bool isValid)
        {
            ClaimID = claimID;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            Amount = amount;
            Type = type;
            Description = description;
            IsValid = isValid;
        }
        public ClaimContent()
        {
            
        }

    }
}
