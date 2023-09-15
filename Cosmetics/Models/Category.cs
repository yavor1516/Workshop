using System;
using System.Collections.Generic;

namespace Cosmetics.Models
{
    public class Category
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 15;

        string name;

        public Category(string name)
        {
            if (name.Length < 2 || name.Length > 10)
                throw new ArgumentException("Name must be between 2 and 10");
            Name = name;
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
                // List encapsulation is tricky.
                throw new NotImplementedException("Not implemented yet.");
            }
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException("Not implemented yet.");
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException("Not implemented yet.");
        }

        public string Print()
        {
            throw new NotImplementedException("Not implemented yet.");
        }
    }
}

