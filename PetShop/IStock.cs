using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public interface IStock
    {
        public int Quality { get; set; }

        public decimal Price { get; set; }
    }
}
