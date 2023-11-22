using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineSYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSYS.Tests
{
    [TestClass()]
    public class CategoriesTests
    {
        [TestMethod()]
        public void SetCategoryTest()
        {

            Categories category = new Categories();
            int newCatID = 6; // Replace with a new CatID
            string newName = "Special Deals";
            string newDescription = "Sales";

            // Act
            category.SetCategory(newCatID, newName, newDescription);

            // Assert
            Assert.IsTrue(category.CategoryExists(newCatID));
        }

        [TestMethod()]
        public void CategoryNameExistsTest()
        {
            Categories category = new Categories();
            string existingname = "Burgers";

            // Assert
            Assert.IsTrue(category.CategoryNameExists(existingname));
        }

        [TestMethod()]
        public void CategoryExistsTest()
        {
            Categories category = new Categories();
            int existingCatID = 1;

            // Assert
            Assert.IsTrue(category.CategoryExists(existingCatID));
        }
    }
}