using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public Car() { }
        public string trunkSize {  get; set; }
        public string speedCapability { get; set; }
        public string logo { get; set; }
        public string homeBranch { get; set; }
        public int numberOfWheels { get; set; }
        public int passengerSeatCount { get; set; }
        public int gasMileageMPG { get; set; }
        public int totalWeightPounds { get; set; }
        public string vehicleName { get; set; }

        public void CarInfo(string name, string TrunkSize, string SpeedCapability, string Logo, string HomeBranch, int NumberOfWheels, int PassengerCount, int GasMileage, int TotalWeight)
        {
            vehicleName = name;
            trunkSize = TrunkSize;
            speedCapability = SpeedCapability;
            logo = Logo;
            homeBranch = HomeBranch;
            numberOfWheels = NumberOfWheels;
            passengerSeatCount = PassengerCount;
            gasMileageMPG = GasMileage;
            totalWeightPounds = TotalWeight;
        }

        public void VehiclePrinter() { }

        public void VehiclePrinter(Car car)
        {
            Console.WriteLine($"Now showcasing the {car.logo} {car.vehicleName} 2023. The {car.logo} vehicle manufacturer hails from {car.homeBranch}.");
            Console.WriteLine($"The {car.vehicleName} has an impressive max speed of {car.speedCapability}. " +
            $"The {car.vehicleName} rests on {car.numberOfWheels} wheels, and has a passenger count of {car.passengerSeatCount}. ");
            Console.WriteLine($"The {car.vehicleName}'s average weight of {car.totalWeightPounds} pounds contributes to its strong mpg of {car.gasMileageMPG}");
            Console.WriteLine($"Last but not least, the {car.vehicleName} has a large trunk size of {car.trunkSize}");
        }

    }
}
