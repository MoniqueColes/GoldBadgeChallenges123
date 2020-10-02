using System;
using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTest
{
    [TestClass]
    public class MenuTest
    {
     
        //get list of claims
        [TestMethod]
        public void GetMethods_ShouldReturnCorrectMethods()
        {
            //arrange
            ClaimProperties newObject = new ClaimProperties();
            ClaimProperties repo = new ClaimProperties();

            repo.AddContentToMethods(newObject);
            //act
            List<ClaimContent> listOfClaims = repo.GetContents();
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
        

        private ClaimProperties _content;
        private ClaimMethods _repo;
        [TestInitialize]

    }
}
