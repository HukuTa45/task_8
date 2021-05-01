using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    public abstract class Pet
    {
        public string Name { get; }
        protected Pet(string name) { 
            Name = name;
        }

        public abstract double Coefficient { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
