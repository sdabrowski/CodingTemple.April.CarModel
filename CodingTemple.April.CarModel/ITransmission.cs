using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    interface ITransmission
    {
        void Shift(IGear gear);

        IGear CurrentGear { get; }

        IGear[] Gears { get; }

    }
}
