using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    public class BritishCat : Cat
    {
        public BritishCat(string name) : base(name)
        {
        }

        public override double Coefficient => 2;
    }
}
