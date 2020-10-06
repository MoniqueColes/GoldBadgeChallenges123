using System;
using System.Collections.Generic;
using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTest
{
    [TestClass]
    public class ClaimsTest
    {
        //get list of claims
        [TestMethod]
        public void GetClaims_ShouldReturnCorrectClaims()
        {
            //arrange
            ClaimMethods repo = new ClaimMethods();
            ClaimProperties _claimObject = new ClaimProperties(1, ClaimType.Car, "Car Accident on 465.", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            repo.AddContentToRepo(_claimObject);
            ClaimProperties _claimObject2 = new ClaimProperties(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            repo.AddContentToRepo(_claimObject2);
            ClaimProperties _claimObject3 = new ClaimProperties(3, ClaimType.Theft, "Stolen pancakes.", 4.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01));
            repo.AddContentToRepo(_claimObject3);

            //act
            List<ClaimProperties> listOfClaims = repo.GetClaims();
            //assert
            bool repoHasContent = listOfClaims.Contains(_claimObject);
            Assert.IsTrue(repoHasContent);
        }

        //add a new claim
        [TestMethod]
        public void AddToClaimMethods_ShouldGetCorrectBool()
        {
            //arrange
            ClaimMethods repo = new ClaimMethods();
            ClaimProperties _claimObject = new ClaimProperties(1, ClaimType.Car, "Car Accident on 465.", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            //act
            bool addResult = repo.AddContentToRepo(_claimObject);
            //assert
            Assert.IsTrue(addResult);
        }

        //call next claim
        [TestMethod]
        public void GetNextClaim_ShouldGetCorrectBool()
        {
            //arrange
            ClaimMethods repo = new ClaimMethods();
            ClaimProperties _claimObject = new ClaimProperties(1, ClaimType.Car, "Car Accident on 465.", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            repo.AddContentToRepo(_claimObject);

            //act
            int getNext = repo.ClaimQueueUp();
            //assert
            Assert.AreEqual(1, getNext);
        }
    }
}
