using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_with_Generic_Approch
{
    public interface IGenericSpecificSpecification<T>
    {
        string GetGenericSpecificSpecification<T>(T data) where T : BikeModel;
    }
}
