using System;
using System.Collections.Generic;
using _01_Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_CafeTest
{
    [TestClass]
    public class MenuTest
    {
        //Add a new object 
        [TestMethod]
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
            MenuContent _newObject = new MenuContent();
            MenuRepo repo = new MenuRepo();
            MenuContent _dishObject = new MenuContent("#1", "Sesame Chicken", "Chicken in sesame sauce with vegetables.", "chicken, sesame sauce, broccoli, carrots, water chestnuts", 8.95);
            repo.AddContentToRepo(_dishObject);
            MenuContent _dishObject2 = new MenuContent("#2", "Beef Lo Mein", "Beef and noodles with vegetables.", "beef, lo mein sauce, broccoli, carrots, water chestnuts", 9.95);
            repo.AddContentToRepo(_dishObject2);

            repo.AddContentToRepo(_newObject);

            //act
            List<MenuContent> listOfDishes = repo.GetContents();

            //assert
            bool repoHasContent = listOfDishes.Contains(_newObject);
            Assert.IsTrue(repoHasContent);
        }

        //Delete object
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //arrange
            MenuRepo repo = new MenuRepo();
            MenuContent _dishObject = new MenuContent("#1", "Sesame Chicken", "Chicken in sesame sauce with vegetables.", "chicken, sesame sauce, broccoli, carrots, water chestnuts", 8.95);
            repo.AddContentToRepo(_dishObject);
            
            //act
            bool deleteResult = repo.DeleteExistingContent(_dishObject);

            //assert
            Assert.IsTrue(deleteResult);
        }
    }
}
