using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingcart
{
    class Shirt
    {
        private static int _quantity;
        private const double price = 1000;

        public Shirt()
        {
            _quantity++;
            
        }

        public static int GetQuantityShirts()
        {
            return _quantity;
        }


        public static int DeleteQuiatityShirts()
        {
            return _quantity--;
        }

        public static double EvaluateDiscountRate()
        {
            if (_quantity >= 3 && _quantity <= 5)
            {
                return ((_quantity * Price) * 0.1) - Price;
            } else if(_quantity > 5)
            {
                return ((_quantity * Price) * 0.1) - Price;
            }
            return 0;
        }
        public static double Price
        {
            get { return price; }
        }
    }

}

