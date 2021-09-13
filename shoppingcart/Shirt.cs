using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingcart
{
    class Shirt
    {
        private static int _quantity;
        private decimal _price;

        public Shirt(decimal price)
        {
            _quantity++;
            _price = price;
        }

        public static int getQuantityShirts()
        {
            return _quantity;
        }

        public static int deleteQuiatityShirts()
        {
            _quantity--;
            return _quantity;
        }
    
    }

}

