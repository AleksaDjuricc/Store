using System;

namespace Store
{
    public abstract class Product
    {
        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price)
        {
            Name = name;
            Brand = brand;
            Price = price;
        }

        public Product()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public decimal CalculateDiscount(decimal price, int discountPercent)
        {
            return Math.Round(price * discountPercent / 100, 2);
        }

        public abstract int CalculateDiscountPercent(DateTime dateOfPurchase);

        public abstract void PrintInformations(decimal quantity);
    }
}
