using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew.Core.Entities
{
    public class Item : IItem
    {
        public Item(string name, int buyprice, int sellprice, int count = 1)
        {
            Name = name;
            Count = count;
            BuyPrice = buyprice;
            SellPrice = sellprice;
        }

        public string Name { get; set; }

        public int Count { get; set; }

        public int BuyPrice { get; set; }

        public int SellPrice { get; set; }

        public void AddCount(int count)
        {
            Count += count;
        }
    }
}
