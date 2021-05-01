using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class PriceCalculator
    {
        public double Calculate(Pet pet)
        {
            switch (pet)
            {
                case Cat cat:
                    return 100 + 50 * cat.Coefficient;
                case Dog dog:
                    return 100 + 70 * dog.Coefficient;
            }
            return 0;
        }
    }
}
