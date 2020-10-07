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
            Assert.AreEqual(1, repo.ListAllBadges().Count);
        }

        [TestMethod]
        public void ListAllBadges_ShouldReturnOneBadge()
        {
            //arrange
            BadgeMethods repo = new BadgeMethods();
            repo.AddNewBadge(22345, new List<string> { "A1", "A4", "B1", "B2" });

            //act
            Dictionary<int, List<string>> _doorList2 = repo.ListAllBadges();

            //assert
            Assert.AreEqual(1, _doorList2.Count);
        }

        [TestMethod]
        public void UpdateBadge_ShouldReturnCorrectBool()
        {
            //arrange
            BadgeMethods repo = new BadgeMethods();
            Dictionary<int, List<string>> _doorList = repo.ListAllBadges();
            _doorList.Add(22345, new List<string> { "A1", "A4", "B1", "B2" });

            //act
            repo.UpdateBadge(22345, "A7" );

            //assert
            Assert.AreEqual(5, _doorList[22345].Count);
        }

        [TestMethod]
        public void DeleteBadge_ShouldReturnCorrectBool()
        {
            //arrange
            BadgeMethods repo = new BadgeMethods();
            Dictionary<int, List<string>> _doorList = new Dictionary<int, List<string>>();
            _doorList.Add(12345, new List<string> { "A7" });

            //act
            repo.DeleteBadge(12345);

            //assert
            Assert.AreEqual(0, repo.ListAllBadges().Count);
        }
    }
}