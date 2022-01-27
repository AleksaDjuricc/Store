using System;

namespace Store
{
    public class Clothes : Product
    {
        private Size size;
        private string color;

        public Clothes(string name, string brand, decimal price, Size size, string color) : base(name, brand, price)
        {
            Size = size;
            Color = color;
        }

        public Clothes() : base()
        {
            
        }

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

            return (dayOfPurchase == DayOfWeek.Saturday || dayOfPurchase == DayOfWeek.Sunday) ? 10 : 0;
        }

        public override void PrintInformations(decimal quantity)
        {
            Console.WriteLine($"\n\n{Name} {Brand} {Size} {Color}");
            Console.WriteLine($"{quantity} x ${Price} = ${quantity * Price}");
        }
    }
}
