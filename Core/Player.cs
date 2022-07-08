using HomeBrew.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew.Core
{
    public class Player
    {
        private static int INVENTORY_SIZE_X = 5;
        private static int INVENTORY_SIZE_Y = 5;

        public Player(string name)
        {
            Name = name;

            Money = 1000;

            Inventory = new IItem[INVENTORY_SIZE_Y, INVENTORY_SIZE_X];

            for(int y = 0; y < INVENTORY_SIZE_Y; y++)
            {
                for(int x = 0; x < INVENTORY_SIZE_X; x++)
                {
                    Inventory[y, x] = null;
                }
            }
        }

        public string Name { get; private set; }

        public int Money { get; set; }

        public IItem[,] Inventory { get; set; }

        public IItem InventoryItemAt(int x, int y)
        {
            return Inventory[y, x];
        }

    }
}
