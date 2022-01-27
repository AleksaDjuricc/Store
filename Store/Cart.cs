using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cart
    {
        private List<(Product,decimal)> products;

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
