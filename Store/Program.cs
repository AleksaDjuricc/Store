using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Food("apples","BrandA",1.5m, new DateTime(2021, 6, 13));
            var milk = new Beverage("milk","BrandM",0.99m, new DateTime(2022, 2, 2));
            var tshirt = new Clothes("T-shirt", "BrandT",15.99m,Size.M, "violet");
            var laptop = new Appliance("laptop", "BrandL", 2345m, "ModelL", new DateTime(2021, 3, 3), 1125);
            
            var listOfItems = new List<(Product p, decimal q)>
            {
                (apple,2.45m), (milk, 3), (tshirt, 2), (laptop, 1)

            };

            var cart = new Cart(listOfItems);

            var purchase = new Purchase(new DateTime(2021, 6, 13, 12, 34, 56));

            Cashier.PrintReceipt(cart, purchase.Date);
        }
    }
}
