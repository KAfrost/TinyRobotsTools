using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyRobotsTools.Models
{
    public class Glitter : IInventoryControl
    {
        public int GlitterId { get; set; }
        private static int nextId = 1;
        public string Name { get; set; }
        
        public string GlitterType { get; set; }

        public double GlitterPrice { get; set; }

        public bool InStock { get; set; }

        public GlitterName GlitterName { get; set; }

        public Glitter()
        {
            GlitterId = nextId;
            nextId++;
        }
        
        public Glitter (string name, string type,  bool instock, double price) : this(){
            Name = name;
            InStock = instock;
            GlitterType = type;
            GlitterPrice = price;
            InStock = instock;
        }

    }
}
