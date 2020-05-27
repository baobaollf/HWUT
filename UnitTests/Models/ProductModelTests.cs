using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json.Serialization;
using System.Text.Json;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_GetSet_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_GetSet_ID_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Id = "one";

            // Assert
            Assert.AreEqual(result.Id, "one");
        }

        [TestMethod]
        public void ProductModel_GetSet_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Maker = "Li";

            // Assert
            Assert.AreEqual(result.Maker, "Li");
        }

        [TestMethod]
        public void ProductModel_GetSet_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Image = "panda.png";

            // Assert
            Assert.AreEqual(result.Image, "panda.png");
        }

        [TestMethod]
        public void ProductModel_GetSet_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Url = "google.com";

            // Assert
            Assert.AreEqual(result.Url, "google.com");
        }

        [TestMethod]
        public void ProductModel_GetSet_Tilte_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Title = "manager";

            // Assert
            Assert.AreEqual(result.Title, "manager");
        }

        [TestMethod]
        public void ProductModel_GetSet_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Description = "A";

            // Assert
            Assert.AreEqual(result.Description, "A");
        }

        [TestMethod]
        public void ProductModel_GetSet_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Sequence = "first";

            // Assert
            Assert.AreEqual(result.Sequence, "first");
        }

        [TestMethod]
        public void ProductModel_GetSet_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Email = "Unknown";

            // Assert
            Assert.AreEqual(result.Email, "Unknown");
        }

        [TestMethod]
        public void ProductModel_GetSet_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Logistics = "";

            // Assert
            Assert.AreEqual(result.Logistics, "");
        }

        [TestMethod]
        public void ProductModel_GetSet_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();


            // Assert
            Assert.AreEqual(result.Ratings.Length, 1);
            Assert.AreEqual(result.Ratings[0], 5);
        }

        [TestMethod]
        public void ProductModel_GetSet_ToString_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(result.ToString(), JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void ProductModel_GetSet_AverageRating_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();


            // Assert
            Assert.AreEqual(result.AverageRating(), 5);

            // Act
            result.Ratings = new int[] { 5, 5 };

            // Assert
            Assert.AreEqual(result.AverageRating(), 5);

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);

            // Act
            result.Ratings = new int[] { 0, 0 };

            // Assert
            Assert.AreEqual(result.AverageRating(), 0);
        }



    }
}
