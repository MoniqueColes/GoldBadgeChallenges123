using System;
using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTest
{
    [TestClass]
    public class ClaimsTest
    {
        [TestMethod]
        public void ClaimPropertyInfo()
        {

            ClaimProperties claimObject = new ClaimProperties(1, "Car", "Car Accident on 465", 400.00, 250418, 270418, true);

            ClaimProperties claimObject2 = new ClaimProperties(2, "Home", "House fire in kitchen.", 4000.00, 110418, 120418, true);

            ClaimProperties claimObject3 = new ClaimProperties(3, "Theft", "Stolen pancakes.", 4.00, 270418, 010618, false);




        }
    }
}
