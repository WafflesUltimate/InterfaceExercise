using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int numberOfWheels { get; set; }
        public int passengerSeatCount { get; set; }
        public int gasMileageMPG {  get; set; } 
        public int totalWeightPounds { get; set; }
        public string vehicleName { get; set; }

        public void VehiclePrinter();
    }
}
