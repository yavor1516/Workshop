using Cosmetics.Commands;
using System;

namespace Cosmetics.Models
{
    public class Product
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 10;
        public const int BrandMinLength = 2;
        public const int BrandMaxLength = 10;

        // "Each product in the system has name, brand, price and gender."
        private string name;
        private string brand;
        private double price;
        private GenderType gender;
        public Product(string name, string brand, double price, GenderType gender)
        {
            Name = name;
            Brand = brand;
            Price = price;
            this.gender = gender;
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can not be under 0");
                }
                this.price = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length< NameMinLength || value.Length> NameMaxLength)
                {
                    throw new ArgumentException("Name length is not between 3 and 10");
                }
                this.name= value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (value.Length < BrandMinLength || value.Length > BrandMaxLength)
                {
                    throw new ArgumentException("Brand name length is not between 2 and 10");
                }
                this.brand = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return gender;
            }
            
        }

        public string Print()
        {
            // Format:
            // #[Name] [Brand]
            // #Price: [Price]
            // #Gender: [Gender]
            throw new ArgumentException("Not implemented yet.");
        }

        public override bool Equals(object p)
        {
            if (p == null || !(p is Product))
            {
                return false;
            }

            if (this == p)
            {
                return true;
            }

            Product otherProduct = (Product)p;

            return this.Price == otherProduct.Price
                    && this.Name == otherProduct.Name
                    && this.Brand == otherProduct.Brand
                    && this.Gender == otherProduct.Gender;
        }
    }
}