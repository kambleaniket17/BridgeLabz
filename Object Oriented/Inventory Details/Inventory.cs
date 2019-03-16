using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented.Test
{ 
    public class Inventory
    {
        public class Rice
        {
            String name;
            float price;
            string weight;
            public override string ToString()
            {
                return string.Format("name{0}", name);
            }
        }
        public class Pulses
        {
            String name;
            float price;
            string weight;
        }
        public class Wheats
        {
            String name;
            float price;
            string weight;
        }
    }
}
