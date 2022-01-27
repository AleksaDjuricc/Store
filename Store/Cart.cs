using System.Collections.Generic;

namespace Store
{
    public class Cart
    {
        private List<(Product, decimal)> products;

        public Cart(List<(Product, decimal)> products)
        {
            Products = products;
        }

        public Cart() : base()
        {

        }

        public List<(Product product, decimal quantity)> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

    }
}
