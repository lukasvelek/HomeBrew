using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew.Core
{
    public class BrewingMachine
    {

        public BrewingMachine(string name, int speed, int price)
        {
            Name = name;
            Price = price;
            Speed = speed;
        }

        public string Name { get; set; }

        public int Speed { get; set; }

        public int Price { get; set; }

    }
}
