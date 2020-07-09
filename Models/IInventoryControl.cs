using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyRobotsTools.Models
{
    public class IInventoryControl
    {
        public int AddInventory(int inventory, int addToStock)
        {
            return inventory + addToStock;
        }

        public int RemoveInventory(int inventory, int removeFromStock)
        {
            return inventory - removeFromStock;
        }

        public bool IsInStock(int inventory)
        {
            if (inventory > 0) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
