using System;

namespace Store
{
    public class Appliance : Product
    {
        private string model;
        private DateTime productionDate;
        private int weight;

        public Appliance(string name, string brand, decimal price, string model, DateTime productionDate, int weight) : base(name, brand, price)
        {
            Model = model;
            ProductionDate = productionDate;
            Weight = weight;
        }

        public Appliance() : base()
        {

        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public DateTime ProductionDate
        {
            get
            {
                return productionDate;
            }
            set
            {
                productionDate = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }


        public override int CalculateDiscountPercent(DateTime dateOfPurchase)
        {
            var dayOfPurchase = dateOfPurchase.DayOfWeek;

            return (dayOfPurchase != DayOfWeek.Saturday && dayOfPurchase != DayOfWeek.Sunday && this.Price > 999) ? 5 : 0;
        }

        public override void PrintInformations(decimal quantity)
        {
            Console.WriteLine($"\n\n{Name} {Brand} {Model}");
            Console.WriteLine($"{quantity} x ${Price} = ${quantity * Price}");
        }
    }
}
