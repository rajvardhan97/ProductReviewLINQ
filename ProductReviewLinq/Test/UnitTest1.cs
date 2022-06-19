using NUnit.Framework;
using System.Collections.Generic;

namespace ProductReviewLinq
{
    public class Tests
    {
        ProductReview product = new ProductReview();
        List<Product> ProductList;

        [SetUp]
        public void Setup()
        {
            ProductReview product;
            ProductList = new List<Product>();
        }
        /// <summary>
        /// TC 1: Adding a Productreview details in list and returns the count
        /// </summary>
        [Test]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = product.AddProductReview();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2: Retrieve Top Three Records Whose Rating is High
        /// </summary>
        [Test]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            int expected = 3;
            var actual = product.RetrieveTopThreeRating();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3: Retrieve records from list based on productid and rating > 3 
        /// </summary>
        [Test]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            string expected = "7 3 3 15 7 ";
            string actual = product.RetrieveRecordsBasedOnRatingAndProductId();
            Assert.AreEqual(expected, actual);
        }

    }
}