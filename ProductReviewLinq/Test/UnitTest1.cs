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

        /// <summary>
        /// TC 4: Retrive the count based on productId
        /// </summary>
        [Test]
        public void TestMethodForCountingProductId()
        {
            string expected = "6 4 4 3 4 1 2 1 ";
            string actual = product.CountingProductId();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 5,7: Retrieving the product id and Review from list
        /// </summary>
        [Test]
        public void TestMethodForProductId()
        {
            string expected = "2 2 3 2 1 2 4 5 3 5 7 9 4 3 8 2 9 1 1 1 2 4 5 3 5 ";
            string actual = product.RetrieveOnlyProductIdAndReviews();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 6: Skip top Five records
        /// </summary>
        [Test]
        public void givenRecords_SkipTopFiveandReturn()
        {
            string expected = "4 3 9 1 3 3 5 5 2 3 9 1 2 1 2 5 7 8 1 5 ";
            string actual = product.SkipTop5Record();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 8: Adding a Productreview details in Data Table
        /// </summary>
        [Test]
        public void GivenCreateFunctionforDT_returnCountofListCreated()
        {
            int expected = 25;
            int actual = product.CreateDataTable();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 9: Retrieve the records whose column islike has true using DataTable
        /// </summary>
        [Test]
        public void TestMethodForReturnsOnlyIsLikeFieldAsTrue()
        {
            string expected = "1 10 1 6 7 8 4 9 10 9 3 15 1 10 7 8 10 ";
            string actual = product.ReturnsOnlyIsLikeFieldAsTrue();
            Assert.AreEqual(expected, actual);
        }
    }
}