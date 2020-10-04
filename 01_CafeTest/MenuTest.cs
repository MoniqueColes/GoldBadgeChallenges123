using System;
using System.Collections.Generic;
using _01_Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_CafeTest
{
    [TestClass]
    public class MenuTest
    {
        public readonly MenuRepo _menuRepo = new MenuRepo();

        [TestInitialize]
        private void Arrange()
        {
            MenuContent _dishObject = new MenuContent("#1", "Sesame Chicken", "Chicken in sesame sauce with vegetables.", "chicken, sesame sauce, broccoli, carrots, water chestnuts", 8.95);
            _menuRepo.AddContentToRepo(_dishObject);
            MenuContent _dishObject2 = new MenuContent("#2", "Beef Lo Mein", "Beef and noodles with vegetables.", "beef, lo mein sauce, broccoli, carrots, water chestnuts", 9.95);
            _menuRepo.AddContentToRepo(_dishObject2);
        }

        [TestMethod]
        //Add a new object
        private void AddToRepo_ShouldGetCorrectBool()
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
        private void GetRepository_ShouldReturnCorrectRepo()
        {
            //arrange
            MenuContent _newObject = new MenuContent();
            MenuRepo repo = new MenuRepo();

            repo.AddContentToRepo(_newObject);
            //act
            List<MenuContent> listOfDishes = repo.GetContents();
            //assert
            bool repoHasContent = listOfDishes.Contains(_newObject);
            Assert.IsTrue(repoHasContent);

        }

        //Delete object
        [TestMethod]
        private void DeleteExistingContent_ShouldReturnTrue()
        {
            //arrange
            MenuContent foundContent = _menuRepo.GetContentByName("Sesame chicken");
            //act
            bool deleteResult = _menuRepo.DeleteExistingContent(foundContent);
            //assert
            Assert.IsTrue(deleteResult);
        }
    }
}
