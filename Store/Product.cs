using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product
    {
        private string name;
        private string brand;
        private decimal price;

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

        public  decimal CalculateDiscount(decimal price, int discountPercent)
        {
            return Math.Round(price*discountPercent/100,2);
        }

        public abstract int CalculateDiscountPercent(DateTime dateOfPurchase);

        public abstract void PrintInformations(decimal quantity);
    }
}
