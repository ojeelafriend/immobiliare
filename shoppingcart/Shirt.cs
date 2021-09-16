using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingcart
{
    class Shirt
    {
        private static int _quantity;
        private static double _discountType;
        private static double _totalPrice;
        private const double price = 1000;
       
        public Shirt()
        {
            _quantity++;
            _totalPrice = _totalPrice + price;
        }

        public static int DeleteQuiatityShirts()
        {
            return Quantity--;
        }

        public static double EvaluateDiscountRate()
        {
            if (Quantity >= 3 && Quantity <= 5)
            {
                DiscoutType = 0.1;
                return TotalPrice - (TotalPrice * DiscoutType);
            } else if(Quantity > 5)
            {
                DiscoutType = 0.2;
                return TotalPrice - (TotalPrice * DiscoutType);
            }
            return 0;
        }

        //Getters
        public static int Quantity
        {
            get { return _quantity; }
            private set { _quantity = value; }
        }
       
        public static double TotalPrice
        {
            get { return _totalPrice; }
        }
        public static double Price
        {
            get { return price; }
        }
        public static double DiscoutType
        {
            get { return _discountType; }
            set { _discountType = value; }
        }
    }

}

