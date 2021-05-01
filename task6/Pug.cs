using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    public class Pug : Dog
    {
        public Pug(string name) : base(name)
        {
        }

        public override double Coefficient => 1.9;
    }
}
