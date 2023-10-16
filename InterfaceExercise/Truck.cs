using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public Truck() { }
        public string bedSize {  get; set; }
        public string towingCapability { get; set; }
        public int numberOfWheels { get; set; }
        public int passengerSeatCount { get; set; }
        public int gasMileageMPG { get; set; }
        public int totalWeightPounds { get; set; }
        public string logo { get; set; }
        public string homeBranch { get; set; }
        public string vehicleName { get; set; }

        public void TruckInfo(string Name, string BedSize, string TowingCapability, string Logo, string HomeBranch, int NumberOfWheels, int PassengerCount, int GasMileage, int TotalWeight)
        {
            vehicleName = Name;
            bedSize = BedSize;
            towingCapability = TowingCapability;
            logo = Logo;
            homeBranch = HomeBranch;
            numberOfWheels = NumberOfWheels;
            passengerSeatCount = PassengerCount;
            gasMileageMPG = GasMileage;
            totalWeightPounds = TotalWeight;
        }

        public void VehiclePrinter() { }

        public void VehiclePrinter(Truck car)
        {
            Console.WriteLine($"Now showcasing the {car.logo} {car.vehicleName} 2023. The {car.logo} vehicle manufacturer hails from {car.homeBranch}.");
            Console.WriteLine($"The {car.vehicleName}'s can tow vehicles of {car.towingCapability}. " +
            $"The {car.vehicleName} rests on {car.numberOfWheels} wheels, and has a passenger count of {car.passengerSeatCount}. ");
            Console.WriteLine($"The {car.vehicleName}'s average weight of {car.totalWeightPounds} pounds contributes to its weak mpg of {car.gasMileageMPG}");
            Console.WriteLine($"Last but not least, the {car.vehicleName} has a large bed size {car.bedSize}");
        }

    }
}
