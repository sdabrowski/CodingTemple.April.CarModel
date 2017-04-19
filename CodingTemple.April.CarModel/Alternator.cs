using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    class Alternator : IAlternator
    {
        public Alternator(IBattery battery)
        {
            Battery = battery;
        }

        public IBattery Battery { get; set; }
        
    }

        //The Alternator charges the battery
        //Checks if the engine is on in order to charge the battery
        //bool IsRunning { get; set; } from IEngine should be set to True
}
