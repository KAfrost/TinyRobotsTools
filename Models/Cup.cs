using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyRobotsTools.Models
{
    public class Cup : IInventoryControl
    {
        public int CupId { get; set; }
        private static int nextId = 1;

        public string CupSize { get; set; }
        public string CupStyle { get; set; }


        public double CupWholesalePrice { get; set; }
        public double CupRetailPrice { get; set; }


        public bool InStock { get; set; }
        public int CupQuantityInStock { get; set; }

        public Cup()
        {
            CupId = nextId;
            nextId++;
        }

        public Cup (string size, string style, double retailPrice, double wholesalePrice bool instock, int quantity) : this()
        {
            CupSize = size;
            CupStyle = style;
            CupRetailPrice = retailPrice;
            CupWholesalePrice = wholesalePrice;
            InStock = instock;
            CupQuantityInStock = quantity;

        }
    }
}
