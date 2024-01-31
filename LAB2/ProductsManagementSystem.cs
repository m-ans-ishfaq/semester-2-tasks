using Challenges.One;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Two
{
    internal class ProductsManagementSystem
    {
        public List<Product> products = [];

        public void AddProduct(int id, string name, double price, string category, string brandName, string country)
        {
            this.products.Add(new Product { 
                ID=id, Name=name, Price=price, Category=category, BrandName=brandName, Country=country
            });
        }

        public void ShowProducts()
        {
            Console.WriteLine($"Products ({products.Count}): \n");
            foreach (Product product in products)
            {
                Console.Write("Name: " + product.Name + "\t");
                Console.Write("Price: " + product.Price + "\t");
                Console.Write("Category: " + product.Category + "\t");
                Console.Write("Brand Name: " + product.BrandName + "\t");
                Console.Write("Country: " + product.Country);
                Console.WriteLine();
            }
        }

        public double CalculcateStoreWorth()
        {
            double storeWorth = 0;
            foreach (Product product in products)
            {
                storeWorth += product.Price;
            }
            return storeWorth;
        }
    }

    class Product
    {
        public int ID;
        public string Name;
        public double Price;
        public string Category;
        public string BrandName;
        public string Country;
    }
}
