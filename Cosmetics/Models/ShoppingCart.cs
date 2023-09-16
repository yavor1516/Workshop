using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> products;

        public ShoppingCart()
        {
            this.products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return new List<Product>(products);
                // List encapsulation is tricky.
                throw new NotImplementedException("Not implemented yet.");
            }
        }

        public void AddProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException("Product cannot be null");
            }
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if(!products.Contains(product))
            {
                throw new ArgumentException("Product not found");
            }
            products.Remove(product);
        }

        public bool ContainsProduct(Product product)
        {
            return products.Contains(product);
        }

        public double TotalPrice()
        {
            return products.Select(p=>p.Price).Sum();
        }
    }
}