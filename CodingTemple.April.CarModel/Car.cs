using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    class Car : ICar
    {
        public Car(IEngine engine)
        {
            Engine = engine;
        }

        public IEngine Engine { get; private set; }
    }
}
