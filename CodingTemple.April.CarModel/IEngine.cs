using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    interface IEngine
    {
        double PowerOutput { get; set; }
        double Effeciency { get; set; }
        double Temperature { get; set; }

        void Start();
        void Stop();
        bool IsRunning { get; set; }
        void Drive(TimeSpan duration);
        void Shift();

        IFuelTank FuelTank { get; set; }
        IOilPan OilPan { get; set; }
        ITransmission Transmission { get; set; }
        IAlternator Alternator {get;set;}
    }
}
