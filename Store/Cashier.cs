using System;

namespace Store
{
    public static class Cashier
    {
        public static void PrintReceipt(Cart cart, DateTime dateOfPurchase)
        {
            var subTotal = 0m;
            var discountTotal = 0m;

            Console.WriteLine($"Date: {dateOfPurchase.ToString("yyyy-MM-dd HH:mm:ss")}\n");
            Console.WriteLine("---Products---");

            foreach (var product in cart.Products)
            {
                var quantity = product.quantity;
                var totalCostItem = Math.Round(quantity * product.product.Price, 2);

                var discountedPercent = 0;
                var discountedPrice = 0m;

                product.product.PrintInformations(quantity);

                if ((discountedPercent = product.product.CalculateDiscountPercent(dateOfPurchase)) != 0)
                {
                    discountedPrice = product.product.CalculateDiscount(totalCostItem, discountedPercent);
                    Console.WriteLine($"#discount {discountedPercent}% -${discountedPrice}");
                }

                subTotal += totalCostItem;
                discountTotal += discountedPrice;
            }

            Console.WriteLine("--------------------------------\n");
            Console.WriteLine($"SUBTOTAL: ${subTotal}");
            Console.WriteLine($"DISCOUNT:-${discountTotal}\n");
            Console.WriteLine($"TOTAL: ${subTotal - discountTotal}");
        }
    }
}
