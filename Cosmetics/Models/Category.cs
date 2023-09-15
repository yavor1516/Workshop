using System;
using System.Collections.Generic;

namespace Cosmetics.Models
{
    public class Category
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 15;
        string name;
        private List<Product> products = new List<Product>();

        public Category(string name)
        {
            if (name.Length < NameMinLength || name.Length > NameMaxLength)
            {
                throw new ArgumentException("Name must be between 1 and 10 characters long.");
            }
            this.name = name;
            products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (products.Contains(product))
            {
                products.Remove(product);
            }
            else
            {
                throw new ArgumentException("Product not found");
            }
        }

        public string Print()
        {
            throw new NotImplementedException("Not implemented yet.");
        }
    }
}

