using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewLinq
{
    public class ProductReview
    {
        public List<Product> ProductList = new List<Product>();

        // UC 1: Adding a Productreview details
        public int AddProductReview()
        {
            ProductList.Add(new Product() { ProductId = 2, UserId = 1, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 2, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 3, UserId = 10, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 5, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 1, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 6, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 4, UserId = 7, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 5, UserId = 8, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 3, UserId = 9, Review = "Average", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 5, UserId = 4, Review = "Average", Rating = 3, IsLike = true });
            ProductList.Add(new Product() { ProductId = 7, UserId = 9, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 9, UserId = 10, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 4, UserId = 3, Review = "Good", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 3, UserId = 2, Review = "Nice", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 8, UserId = 9, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 3, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 9, UserId = 3, Review = "Nice", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 15, Review = "Nice", Rating = 4, IsLike = true });
            ProductList.Add(new Product() { ProductId = 1, UserId = 10, Review = "Average", Rating = 2, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 1, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 10, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 4, UserId = 7, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 5, UserId = 8, Review = "Bad", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 3, UserId = 9, Review = "Nice", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 5, UserId = 10, Review = "Average", Rating = 3, IsLike = true });

            return ProductList.Count;
        }

        // UC 2: Retrieve Top Three Records Whose Rating is High
        public int RetrieveTopThreeRating()
        {
            AddProductReview();
            var res = (from product in ProductList orderby product.Rating descending select product).Take(3).ToList();
            DisplayList();
            return res.Count;
        }

        // UC 3: Retrieve  records from list based on productid and Rating > 3  
        public string RetrieveRecordsBasedOnRatingAndProductId()
        {
            AddProductReview();
            string nameList = "";
            var productList = (from product in ProductList where product.Rating > 3 && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) select product);
            foreach (var product in productList)
            {
                nameList += product.UserId + " ";
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.ProductId, product.UserId, product.Review, product.Rating, product.IsLike);
            }
            return nameList;
        }

        // UC 4: Retrieve count of Product ID
        public string CountingProductId()
        {
            string nameList = "";
            AddProductReview();
            var productList = ProductList.GroupBy(x => x.ProductId).Select(a => new { ProductId = a.Key, count = a.Count() });
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId " + element.ProductId + " " + "Count " + " " + element.count);
                nameList += element.count + " ";
            }
            return nameList;
        }

        // UC 5: Retrieving the product id and Review from list
        public string RetrieveOnlyProductIdAndReviews()
        {
            string result = "";
            AddProductReview();
            var productList = ProductList.Select(product => new { ProductId = product.ProductId, Review = product.Review }).ToList();
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId: " + element.ProductId + "\tReview: " + element.Review);
                result += element.ProductId + " ";
            }
            return result;
        }

        // UC 6: Skip top Five records
        public string SkipTop5Record()
        {
            AddProductReview();
            string nameList = "";
            var result = (from product in ProductList orderby product.Rating descending select product).Skip(5).ToList();
            foreach (var element in result)
            {
                nameList += element.ProductId + " ";
            }
            return nameList;
        }

        //Display List Content
        public void DisplayList()
        {
            foreach (Product product in ProductList)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.ProductId, product.UserId, product.Review, product.Rating, product.IsLike);
            }
        }
    }
}
