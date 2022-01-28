using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Deck
    {
        public Deck()
        {
            Class1 = new List<Class1>();
            List<string> Colors = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue" };
            List<string> Numbers = new List<string>() { "Two", "Three", "Four", "Five", "Six", };
            List<string> Letters = new List<string>() { "A", "E", "I", "O", "U" };

            foreach (string Number in Numbers)
            {
                foreach (string Color in Colors)
                {
                    foreach (string Letter in Letters)
                    {
                        
                    }
                        
                }
            }
        }
    }
}
