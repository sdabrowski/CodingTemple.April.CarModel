using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    interface IOilPan
    {
        double Capacity { get; }

        void Consume(double amount);

        void Refill(double amount);
    }
}
