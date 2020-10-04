using System;
using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTest
{
    [TestClass]
    public class ClaimsTest
    {
        public readonly ClaimMethods _claimMethods = new ClaimMethods();
        public void SeedContent()
        {
            ClaimProperties _claimObject = new ClaimProperties(1, ClaimType.Car, "Car Accident on 465.", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            _claimMethods.AddContentToRepo(_claimObject);
            ClaimProperties _claimObject2 = new ClaimProperties(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            _claimMethods.AddContentToRepo(_claimObject2);
            ClaimProperties _claimObject3 = new ClaimProperties(3, ClaimType.Theft, "Stolen pancakes.", 4.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01));
            _claimMethods.AddContentToRepo(_claimObject3);
        }




        //get list of claims
        [TestMethod]
        public void GetClaims_ShouldReturnCorrectClaims()
        {
            //arrange
            ClaimProperties newObject = new ClaimProperties();
            ClaimMethods repo = new ClaimMethods();

            _claimMethods.AddContentToRepo(newObject);
            //act
            List<ClaimProperties> listOfClaims = _claimMethods.GetClaims();
            //assert
            bool repoHasContent = listOfClaims.Contains(newObject);
            Assert.IsTrue(repoHasContent);

        }


        //add a new claim
        public void AddToClaimMethods_ShouldGetCorrectBool()
        {
            //arrange
            ClaimProperties content = new ClaimProperties();
            ClaimProperties repository = new ClaimProperties();
            //act
            bool addResult = repository.AddContentToMethods(content);
            //assert
            Assert.IsTrue(addResult);

        }

        //call next claim
        public void GetNextClaim_ShouldGetCorrectBool()
        {
            //arrange
            ClaimProperties content = new ClaimProperties();
            //act
            bool

            //assert
            Assert.IsTrue();


        }
    }
}
