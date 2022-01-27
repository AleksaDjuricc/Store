using System;

namespace Store
{
    public abstract class PerishableProduct : Product
    {
        private DateTime expirationDate;

        protected PerishableProduct(string name, string brand, decimal price, DateTime expirationDate) : base(name, brand, price)
        {
            ExpirationDate = expirationDate;
        }

        public PerishableProduct() : base()
        {

        }

        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                expirationDate = value;
            }
        }

        public override int CalculateDiscountPercent(DateTime dateOfPurchase)
        {
            var discount = 0;
            var daysToExpire = (this.ExpirationDate.Date - dateOfPurchase.Date).TotalDays;

            if (daysToExpire == 0)
                discount = 50;

            else if (daysToExpire <= 5)
                discount = 10;

            return discount;
        }

        public override void PrintInformations(decimal quantity)
        {
            Console.WriteLine($"\n\n{Name} {Brand}");
            Console.WriteLine($"{quantity} x ${Price} = ${quantity * Price}");
        }
    }
}
