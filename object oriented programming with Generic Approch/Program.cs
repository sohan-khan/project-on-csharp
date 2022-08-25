using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_with_Generic_Approch
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeModel NBike = new BikeModel { BikeBodyType = BikeBodyType.NakedBike, modelName = "Hornet", yearMake = DateTime.Now, CapacityInCC = 160, EngineType = "Air Cooled", FrontBrake = "Disc", NoOfGear = 6, RearBreake = "Disc", MaxPower = 15.5, MaxTorque = 17.5 };
            GenericBikeModel<BikeModel> bikeModel = new GenericBikeModel<BikeModel>();
            Console.WriteLine(BikeBodyType.NakedBike);
            Console.WriteLine("==============Specification==============");
            Console.WriteLine(bikeModel.GetGenericSpecification(NBike));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            BikeModel SBike = new BikeModel { BikeBodyType = BikeBodyType.SportsBike, modelName = "MT", yearMake = DateTime.Now, CapacityInCC = 160, EngineType = "Air Colled", FrontBrake = "Disc", NoOfGear = 6, RearBreake = "Disc", MaxPower = 15.5, MaxTorque = 17.5 };
            GetSpecificSpecification<BikeModel> Mbikemodel = new GetSpecificSpecification<BikeModel>();
            Console.WriteLine(BikeBodyType.SportsBike);
            Console.WriteLine("==============Specification==============");
            Console.WriteLine(Mbikemodel.GetGenericSpecificSpecification(SBike));
            Console.ReadKey();
        }
    }
}
