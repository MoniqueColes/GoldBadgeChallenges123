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
