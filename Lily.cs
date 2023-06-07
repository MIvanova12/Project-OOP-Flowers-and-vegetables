using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2
{
    public class Lily:IFlower
    {
        public string Name { get; } = "Lily";
        public string Color { get; } = "White";
        public string BloomTime { get; } = "Summer";
    }
}
