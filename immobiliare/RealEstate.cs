using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immobiliare
{
    abstract class RealEstate
    {
        protected string direction;
        protected double squareMeter;
        protected double price;
        protected int age;

        public abstract double CalculateImmo();
        public static double ReductionPrice(double price,double squareMeter, int age)
        {
            double reduction;
            if (age == 15)
            {
                reduction = 0.1;
                return (price * squareMeter) - (price * reduction);
            }
            else if (age > 15)
            {
                reduction = 0.2;
                return (price * squareMeter) - (price * reduction);
            }
            return price;
        }
        
    }
}
