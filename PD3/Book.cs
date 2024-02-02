using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTasks.PD3
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int PublicationYear;
        public double Price;
        public int QuantityInStock;

        public string GetTitle()
        {
            return $"Title: {Title}";
        }
        public string GetAuthor()
        {
            return $"Author: {Author}";
        }

        public string GetPublicationYear()
        {
            return $"Publication Year: {PublicationYear}";
        }

        public string GetPrice()
        {
            return $"Price: {Price}";
        }

        public string GetQuantityInStock()
        {
            return $"Quantity In Stock: {QuantityInStock}";
        }

        public void SellCopies(int numberOfCopies)
        {
            if (QuantityInStock <  numberOfCopies)
            {
                Console.WriteLine("Unavailable !");
                return;
            }
            QuantityInStock -= numberOfCopies;
        }

        public void Restock(int additionalCopies)
        {
            QuantityInStock += additionalCopies;
        }

        public string BookDetails()
        {
            List<string> details = [GetTitle(), GetAuthor(), GetPublicationYear(), GetPrice(), GetQuantityInStock()];
            return string.Join("\n", details);
        }
    }
}
