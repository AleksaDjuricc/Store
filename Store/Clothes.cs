using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Clothes : Product
    {
        private Size size;
        private string color;

        public Size Size
        {
            get 
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public override int CalculateDiscountPercent(DateTime dateOfPurchase)
        {
            var dayOfPurchase = dateOfPurchase.DayOfWeek;

            if (dayOfPurchase == DayOfWeek.Saturday || dayOfPurchase == DayOfWeek.Sunday)
                return 10;

            return 0;
        }

        public override void PrintInformations(decimal quantity)
        {
            Console.WriteLine($"\n\n{Name} {Brand} {Size} {Color}");
            Console.WriteLine($"{quantity} x ${Price} = ${quantity * Price}");
        }
    }
}
