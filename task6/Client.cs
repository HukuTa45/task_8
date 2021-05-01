using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class Client
    {
        public string Name { get; }
        public Pet Pet { get; }

        public Client(string name, Pet pet){
            Name = name;
            Pet = pet;
        }
        public override string ToString()
        {
            return $"Клиент {Name}, питомец - {Pet}.";
        }
    }
}
