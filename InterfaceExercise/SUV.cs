using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {

        public SUV() { }
        public string cargoHoldSize {  get; set; }
        public string offRoadCapability { get; set; }
        public string logo { get; set; }
        public string homeBranch { get; set; }
        public int numberOfWheels { get; set; }
        public int passengerSeatCount { get; set; }
        public int gasMileageMPG { get; set; }
        public int totalWeightPounds { get; set; }
        public string vehicleName { get; set; }

        public void SUVInfo(string name, string CargoHold, string OffRoad, string Logo, string HomeBranch, int NumberOfWheels, int PassengerCount, int GasMileage, int TotalWeight)
        {
            vehicleName = name;
            cargoHoldSize = CargoHold;
            offRoadCapability = OffRoad;
            logo = Logo;
            homeBranch = HomeBranch;
            numberOfWheels = NumberOfWheels;
            passengerSeatCount = PassengerCount;
            gasMileageMPG = GasMileage;
            totalWeightPounds = TotalWeight;
        }

        public void VehiclePrinter() { }

        public void VehiclePrinter(SUV car)
        {
            Console.WriteLine($"Now showcasing the {car.logo} {car.vehicleName} 2023. The {car.logo} vehicle manufacturer hails from {car.homeBranch}.");
            Console.WriteLine($"The {car.vehicleName}'s off road capabilities are {car.offRoadCapability}. " +
            $"The {car.vehicleName} rests on {car.numberOfWheels} wheels, and has a passenger count of {car.passengerSeatCount}. ");
            Console.WriteLine($"The {car.vehicleName}'s average weight of {car.totalWeightPounds} pounds contributes to its weak mpg of {car.gasMileageMPG}");
            Console.WriteLine($"Last but not least, the {car.vehicleName} has a large cargo hold of {car.cargoHoldSize}");
        }

    }
}
