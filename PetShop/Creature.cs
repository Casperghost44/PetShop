using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class Creature
    {
        public int Age { get; set; }
        public int MaxAge { get; set; }
        public string Speak(string[] words)
        {
            return words[0];
        }

    }
}
