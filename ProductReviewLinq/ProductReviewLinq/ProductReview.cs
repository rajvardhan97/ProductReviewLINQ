using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewLinq
{
    public class ProductReview
    {
        public List<Product> ProductList = new List<Product>();
         
        public int AddProduct()
        {
            ProductList.Add(new Product() { ProductId = 2, UserId = 1, Review = "Bad", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 2, Review = "Average", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 3, UserId = 3, Review = "Nice", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 5, Review = "Bad", Rating = 7, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 1, Review = "Nice", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 6, Review = "Average", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 4, UserId = 7, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 5, UserId = 8, Review = "Average", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 3, UserId = 9, Review = "Bad", Rating = 3, IsLike = false });
            ProductList.Add(new Product() { ProductId = 5, UserId = 4, Review = "Average", Rating = 3, IsLike = true });
            ProductList.Add(new Product() { ProductId = 7, UserId = 9, Review = "Good", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 9, UserId = 5, Review = "Good", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 4, UserId = 3, Review = "Bad", Rating = 5, IsLike = false });
            ProductList.Add(new Product() { ProductId = 3, UserId = 2, Review = "Bad", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 8, UserId = 9, Review = "Average", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 3, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 9, UserId = 3, Review = "Bad", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 15, Review = "Good", Rating = 4, IsLike = true });
            ProductList.Add(new Product() { ProductId = 1, UserId = 9, Review = "Bad", Rating = 2, IsLike = false });
            ProductList.Add(new Product() { ProductId = 1, UserId = 1, Review = "Good", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 2, UserId = 6, Review = "Average", Rating = 2, IsLike = true });
            ProductList.Add(new Product() { ProductId = 4, UserId = 7, Review = "Good", Rating = 5, IsLike = true });
            ProductList.Add(new Product() { ProductId = 5, UserId = 8, Review = "Average", Rating = 1, IsLike = true });
            ProductList.Add(new Product() { ProductId = 3, UserId = 9, Review = "Bad", Rating = 4, IsLike = false });
            ProductList.Add(new Product() { ProductId = 5, UserId = 4, Review = "Average", Rating = 3, IsLike = true });

            return ProductList.Count;
        }
        public void DisplayList()
        {
            foreach (var item in ProductList)
            {
                Console.WriteLine("Product ID: " + item.ProductId);
                Console.WriteLine("User ID: " + item.UserId);
                Console.WriteLine("Review: " + item.Review);
                Console.WriteLine("Rating: " + item.Rating);
                Console.WriteLine("Liked: " + item.IsLike);
            }
        }
    }
}
