using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    public sealed class Bike : BikeModel, Ispecification
    {
        public BikeBodyType BikeBodyType { get; set; }
        public double MaxPower { get; set; }
        public double MaxTorque { get; set; }
        public string EngineType { get; set; }
        public string FrontBrake { get; set; }
        public string RearBreake { get; set; }

        List<string> _specification = new List<string>();

        public void addspecification(string specification)
        {
            _specification.Add(specification);
        }

        public string Showspecification()
        {
            return string.Join(",", _specification.ToArray());
        }


    }
}
