using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_with_Generic_Approch
{
    public class BikeModel
    {
        public string modelName { get; set; }
        public DateTime yearMake { get; set; }
        public int NoOfGear { get; set; }
        public int CapacityInCC { get; set; }
        public BikeBodyType BikeBodyType { get; set; }
        public double MaxPower { get; set; }
        public double MaxTorque { get; set; }
        public string EngineType { get; set; }
        public string FrontBrake { get; set; }
        public string RearBreake { get; set; }
    }
}
