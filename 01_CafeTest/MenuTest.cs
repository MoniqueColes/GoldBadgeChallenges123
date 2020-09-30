using System;
using System.Collections.Generic;
using _01_Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_CafeTest
{
    [TestClass]
    public class MenuTest
    {
        [TestMethod]
        public void MenuContentInfo()
        {
            MenuContent dishObject = new MenuContent("#1","Sesame Chicken", "Chicken in sesame sauce with vegetables.", "chicken, sesame sauce, broccoli, carrots, water chestnuts", 8.95);

            MenuContent dishObject2 = new MenuContent("#2", "Beef Lo Mein", "Beef and noodles with vegetables.", "beef, lo mein sauce, broccoli, carrots, water chestnuts", 9.95);
        }
        //Add a new object
        public void AddToRepo_ShouldGetCorrectBool()
        {
            //arrange
            MenuContent content = new MenuContent();
            MenuRepo repository = new MenuRepo();
            //act
            bool addResult = repository.AddContentToRepo(content);
            //assert
            Assert.IsTrue(addResult);

        }
        //Get menu 
        [TestMethod]
        public void GetRepository_ShouldReturnCorrectRepo()
        {
            //arrange
            MenuContent newObject = new MenuContent();
            MenuRepo repo = new MenuRepo();

            repo.AddContentToRepo(newObject);
            //act
            List<MenuContent> listOfDishes = repo.GetContents();
            //assert
            bool repoHasContent = listOfDishes.Contains(newObject);
            Assert.IsTrue(repoHasContent);

        }
        
        private MenuContent _content;
        private MenuRepo _repo;
        [TestInitialize]

        //Delete object
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //arrange
            MenuContent foundContent = _repo.GetContentByName("Sesame chicken");
            //act
            bool deleteResult = _repo.DeleteExistingContent(foundContent);
            //assert
            Assert.IsTrue(deleteResult);
        }
    }
}
