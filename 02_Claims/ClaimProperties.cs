using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public enum ClaimType 
    {
        Car = 1,
        Home,
        Theft
    }
    public class ClaimProperties
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public ClaimProperties() { }

        public ClaimProperties(int claimID, ClaimType typeOfClaim, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }

        public bool IsValid
        {
            get
            {
                TimeSpan timeSpan = DateOfClaim - DateOfIncident;
                if (timeSpan.TotalDays <= 30)
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
}
