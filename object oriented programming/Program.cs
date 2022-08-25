using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string mName = string.Empty;
                string EType = string.Empty;
                string fbType = string.Empty;
                string RbType = string.Empty;
                Console.WriteLine("Please insert SportsBike=1,CafeRacer=2,NakedBike=3,AdventureBikes=4");
                BikeBodyType bikebody = (BikeBodyType)int.Parse(Console.ReadLine());

                Console.Write("Please Insert A model Name :");
                string mname = Console.ReadLine();
                if (mname.All(char.IsLetter))
                {
                    mName = mname;
                }
                else
                {
                    Console.WriteLine("Please Insert Srting");
                }
                Console.Write("Please Insert Year Make Date :");
                DateTime yMake = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Please Insert Number of gear :");
                int nGear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Capacity in CC :");
                int CCC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Max BHP Power :");
                double MBP = Convert.ToDouble(Console.ReadLine());
                Console.Write("Max torque Power :");
                double mtp = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please Insert A Engine Type :");

                string Etype = Console.ReadLine();
                if (Etype.All(char.IsLetter))
                {
                    EType = Etype;
                }
                else
                {
                    Console.WriteLine("Please Insert Srting");
                }
                Console.Write("Please Insert A Front Break Type5 :");
                string fbtype = Console.ReadLine();
                if (fbtype.All(char.IsLetter))
                {
                    fbType = fbtype;
                }
                else
                {
                    Console.WriteLine("Please Insert Srting");
                }
                Console.Write("Please Insert A Rear Break Type :");
                string Rbtype = Console.ReadLine();
                if (Rbtype.All(char.IsLetter))
                {
                    RbType = Rbtype;
                }
                else
                {
                    Console.WriteLine("Please Insert Srting");
                }
                Bike b = new Bike()
                {
                    modelName = mName,
                    yearMake = yMake,
                    NoOfGear = nGear,
                    CapacityInCC = CCC,
                    MaxPower = MBP,
                    MaxTorque = mtp,
                    EngineType = EType,
                    FrontBrake = fbType,
                    RearBreake = RbType

                };
                Console.WriteLine();
                Console.WriteLine("==================Bike Details==================");
                Console.WriteLine(bikebody + "\n" + "Model Name :" + b.modelName + Environment.NewLine + "Year Make :" + b.yearMake + Environment.NewLine + "Number of gear :" + b.NoOfGear + Environment.NewLine + "Capacity in CC :" + b.NoOfGear + Environment.NewLine + b.MaxPower + Environment.NewLine + "Max torque Power :" + mtp + Environment.NewLine + "Engine Type :" + EType + Environment.NewLine + "Front Break Type :" + fbType + Environment.NewLine + "Rear Break Type :" + RbType);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }
}
