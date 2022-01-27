using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Appliance : Product
    {
        private string model;
        private DateTime productionDate;
        private int weight;

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

            if (dayOfPurchase != DayOfWeek.Saturday && dayOfPurchase != DayOfWeek.Sunday && this.Price > 999)
                return 5;

            return 0;
        }

        public override void PrintInformations(decimal quantity)
        {
            Console.WriteLine($"\n\n{Name} {Brand} {Model}");
            Console.WriteLine($"{quantity} x ${Price} = ${quantity * Price}");
        }
    }
}
