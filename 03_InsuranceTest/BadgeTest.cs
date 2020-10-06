using System;
using System.Collections.Generic;
using _03_InsuranceBadge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_InsuranceTest
{
    [TestClass]
    public class BadgeTest
    {
        [TestMethod]
        public void AddNewBadge_ShouldReturnCorrectBadge()
        {
            //arrange
            BadgeMethods repo = new BadgeMethods();

            //act
            repo.AddNewBadge(12345, new List<string> { "A7" });

            //assert
            Assert.IsTrue(addResult);
        }


        [TestMethod]
        public void ListAllBadges_ShouldReturnCorrectBadges()
        {
            //arrange
            BadgeMethods repo = new BadgeMethods();
            _doorList.Add(12345, new List<string> { "A7" });
            _doorList.Add(22345, new List<string> { "A1", "A4", "B1", "B2" });
            _doorList.Add(32345, new List<string> { "5" });
            Dictionary<int, List<string>> _doorList = new Dictionary<int, List<string>>();

            //act
            List<ClaimProperties> listOfClaims = repo.GetClaims();
            //assert
            bool repoHasContent = listOfClaims.Contains(_claimObject);
            Assert.IsTrue(repoHasContent);
        }

        [TestMethod]
        public void UpdateBadge_ShouldReturnCorrectBool()
        {
            //arrange
            _doorList.Add(12345, new List<string> { "A7" });


        }

        [TestMethod]
        public void DeleteBadge_ShouldReturnCorrectBool()
        {



        }
    }
}