using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_with_Generic_Approch
{
    public class GetSpecificSpecification<T> : IGenericSpecificSpecification<T>
    {
        public string GetGenericSpecificSpecification<T1>(T1 data) where T1 : BikeModel
        {
            string specification = "";
            switch (data.BikeBodyType)
            {
                case BikeBodyType.AdventureBikes:
                    specification = "Sometimes the fastest way to get there is to stop for the night.";
                    break;
                case BikeBodyType.CafeRacer:
                    specification = "Motorcycle riders may we find peace in that open road";
                    break;
                case BikeBodyType.NakedBike:
                    specification = "You can’t buy happiness, but you can buy a bicycle and that’s pretty close";
                    break;
                case BikeBodyType.SportsBike:
                    specification = "Never too old to ride one";
                    break;
                default:
                    specification = "Unknown Bike Model";
                    break;
            }
            return specification;
        }
    }
}
