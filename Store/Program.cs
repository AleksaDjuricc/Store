using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple = new Food();
            apple.Name = "apples";
            apple.Brand = "BrandA";
            apple.Price = 1.5m;
            apple.ExpirationDate = new DateTime(2021, 6, 13);

            Beverage milk = new Beverage();
            milk.Name = "milk";
            milk.Brand = "BrandM";
            milk.Price = 0.99m;
            milk.ExpirationDate = new DateTime(2022, 2, 2);

            Clothes tshirt = new Clothes();
            tshirt.Name = "T-shirt";
            tshirt.Brand = "BrandT";
            tshirt.Price = 15.99m;
            tshirt.Size = Size.M;
            tshirt.Color = "violet";

            Appliance laptop = new Appliance();
            laptop.Name = "laptop";
            laptop.Brand = "BrandL";
            laptop.Price = 2345m;
            laptop.Model = "ModelL";
            laptop.ProductionDate = new DateTime(2021, 3, 3);
            laptop.Weight = 1125;

            var listOfItems = new List<(Product p, decimal q)>
            {
                (apple,2.45m), (milk, 3), (tshirt, 2), (laptop, 1)

            };

            Cart cart = new Cart();
            cart.Products = listOfItems;

            var dateOfPurchase = new DateTime(2021, 6, 13,12,34,56);

            Purchase purchase = new Purchase(dateOfPurchase);

            Cashier.PrintReceipt(cart, purchase.Date);
        }
    }
}
