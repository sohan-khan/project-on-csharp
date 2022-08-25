using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_with_Generic_Approch
{
    public class GenericBikeModel<T> : IGenericSpecification<T>
    {
        public string GetGenericSpecification(T obj)
        {
            string specification = string.Empty;
            if (obj is BikeModel)
            {
                BikeModel bm = obj as BikeModel;
                switch (bm.BikeBodyType)
                {
                    case BikeBodyType.AdventureBikes:
                        specification = "This Is for Hill track Bike";
                        break;
                    case BikeBodyType.CafeRacer:
                        specification = "Off Road Bike";
                        break;
                    case BikeBodyType.NakedBike:
                        specification = "On Road Racing Bike";
                        break;
                    case BikeBodyType.SportsBike:
                        specification = "VIP bike for VIP person";
                        break;
                    default:
                        specification = "Unknown Bike Model";
                        break;
                }

            }
            else
            {
                specification = "Not a Bike";
            }
            return specification;
        }
    }
}
