using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immobiliare
{
    class Flat : RealEstate
    {
        int numberFlat;
        public Flat(string direction, int age, double squareMeter, double price, int numberFlat)
        {
            this.direction = direction;
            this.age = age;
            this.squareMeter = squareMeter;
            this.price = price;
            this.numberFlat = numberFlat;
        }
        public override double CalculateImmo()
        {
            double increment;
            price = ReductionPrice(price,squareMeter, age);
            if(numberFlat >= 3)
            {
                increment = 0.3;
                return price + (price * increment);
            }
            return price;
        }
    }
}
