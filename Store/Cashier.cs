using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach(var item in cart.Products)
            {
                var quantity = item.quantity;
                var totalCostItem = Math.Round(quantity * item.product.Price,2);

                var discountedPercent = 0;
                var discountedPrice = 0m;

                item.product.PrintInformations(quantity);

                if ((discountedPercent = item.product.CalculateDiscountPercent(dateOfPurchase)) != 0)
                {
                    discountedPrice = item.product.CalculateDiscount(totalCostItem, discountedPercent);
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
