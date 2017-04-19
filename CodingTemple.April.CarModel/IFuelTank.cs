using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    interface IFuelTank
    {
        double Capacity { get; }

        void Consume(double amount);

        void Refuel(double amount);
    }
}
