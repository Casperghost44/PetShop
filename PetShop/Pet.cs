using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Pet : Animal, IStock
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Pet {Name}, Kind {Kind}, Age {Age}, Price {Price}, Quality {Quality}";
        }
    }
}
