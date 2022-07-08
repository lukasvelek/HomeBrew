using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew.Core
{
    public class Brewery
    {

        public Brewery()
        {
            BrewingMachines = new List<BrewingMachine>();
        }

        public List<BrewingMachine> BrewingMachines { get; set; }

    }
}
