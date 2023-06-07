using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2
{
    public class Tomato:IVegetable
    {
        public string Name { get; } = "Tomato";
        public string Color { get; } = "Red";
        public string HarvestTime { get; } = "Late Summer";
    }
}
