using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    public class Terrier : Dog
    {
        public Terrier(string name) : base(name)
        {
        }

        public override double Coefficient => 3.6;
    }
}
