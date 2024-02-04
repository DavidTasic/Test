using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dependancy
{
    
    
    public class SecondCar :  ICarDetails
    {
        public void carName()
        {
            Console.WriteLine("Audi");
        }

        public void checkEngine()
        {
            Console.WriteLine("EngineFailure");
        }
        public void enginePower()
        {
            Console.WriteLine("150ps");
        }
        public void engineConsumption()
        {
            Console.WriteLine("7L");
        }

    }
}
