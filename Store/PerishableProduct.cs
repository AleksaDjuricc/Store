using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class PerishableProduct : Product
    {
       private DateTime expirationDate;

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
            Console.WriteLine($"{quantity} x ${Price} = ${quantity*Price}");
        }
    }
}
