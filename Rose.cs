using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2
{
   public class Rose:IFlower
    {
        public string Name { get; } = "Rose";
        public string Color { get; } = "Red";
        public string BloomTime { get; } = "Spring";
    }
}
