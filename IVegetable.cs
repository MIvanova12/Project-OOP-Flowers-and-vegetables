using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2
{
    public interface IVegetable:IPlant
    {
        string HarvestTime { get; }
    }
}
