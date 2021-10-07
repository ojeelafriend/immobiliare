using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immobiliare
{
    class Local : RealEstate
    {
        int numberWindows;

        public Local(string direction, int age, double squareMeter, double price, int numberWindows)
        {
            this.direction = direction;
            this.age = age;
            this.squareMeter = squareMeter;
            this.price = price;
            this.numberWindows = numberWindows;
        }

        public override double CalculateImmo()
        {
            double increment;
            double reduction;

            price = ReductionPrice(price, squareMeter, age);

            if(squareMeter > 50)
            {
                increment = 0.1;
                price = price + (price * increment);
            }

            if (numberWindows > 4)
            {
                    reduction = 0.2;
                    return price - (price * reduction);
            }
            else if (numberWindows <= 1)
            {
                    increment = 0.2;
                    return price + (price * increment);
            }

            return price;
        }
    }
}
