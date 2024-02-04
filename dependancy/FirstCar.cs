using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependancy
{
    public class FirstCar : ICarDetails
    {
        public void carName()
        {
            Console.WriteLine("Bmw");
        }

        public void checkEngine()
        {
            Console.WriteLine("EngineFailure");
        }

        public void enginePower()
        {
            Console.WriteLine("143ps");
        }

        public void engineConsumption()
        {
            Console.WriteLine("10L");
        }
    }
}
