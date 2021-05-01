using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    public class Bulldog : Dog
    {
        public Bulldog(string name) : base(name)
        {
        }

        public override double Coefficient => 4.2;
    }
}
