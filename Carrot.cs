using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2
{
   public class Carrot:IVegetable
    {
        public string Name { get; } = "Carrot";
        public string Color { get; } = "Orange";
        public string HarvestTime { get; } = "Late Summer";
    }
}
