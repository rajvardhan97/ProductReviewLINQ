using NUnit.Framework;

namespace ProductReviewLinq
{
    public class Tests
    {
        ProductReview product = new ProductReview();
        [SetUp]
        public void Setup()
        {
            ProductReview product;
        }

        [Test]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = product.AddProduct();
            Assert.AreEqual(expected, actual);
        }
    }
}