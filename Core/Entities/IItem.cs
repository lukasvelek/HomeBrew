using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew.Core.Entities
{
    public interface IItem
    {
        string Name { get; set; }

        int Count { get; set; }

        int BuyPrice { get; set; }
        int SellPrice { get; set; }
    }
}
