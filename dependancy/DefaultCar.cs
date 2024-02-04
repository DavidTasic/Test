using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependancy
{
    public  class DefaultCar
    {
        private readonly IEnumerable<ICarDetails> _carDetails;
        public DefaultCar(IEnumerable<ICarDetails> carDetails)
        {
            _carDetails = carDetails;
        }

       public  void Run()
        {
            foreach (var car in _carDetails)
            {
                car.carName();
                car.enginePower();
                car.checkEngine();
                car.engineConsumption();

            }
        }
        
        
    }
}
