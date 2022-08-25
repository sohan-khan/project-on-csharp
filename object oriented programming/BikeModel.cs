using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    public abstract class BikeModel
    {
        public string modelName { get; set; }
        public DateTime yearMake { get; set; }
        public int NoOfGear { get; set; }
        public int CapacityInCC { get; set; }
    }
}
