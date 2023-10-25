using System.Drawing;
using Vehicles.Contracts;

namespace Vehicles.VehiclesRealisations
{
    internal class Motorbike : BaseVehicle
    {
        protected uint _fuel;
        private readonly uint _fuelCapacity;
        public override uint Fuel 
        { 
            get 
            {
                return _fuel;
            } 
            protected set 
            {
                _fuel = value;
            }
        }
        public double EngineVolume { get; init; }
        public new void Move()
        {
            if (Fuel > 2)
            {
                Console.WriteLine($"{vehicleType} движется co скорость {MaxSpeed}");
                Fuel -= 2;
            }
            else
            {
                Console.WriteLine($"{vehicleType} не может двигаться");
            }
        }
        public void Move(string specificKindOfVehicle)
        {
            if (Fuel > 2)
            {
                Console.WriteLine($"{vehicleType} {specificKindOfVehicle} движется");
                Fuel -= 2;
            }
            else
            {
                Console.WriteLine($"{vehicleType} {specificKindOfVehicle} не может двигаться");
            }
        }
        public override void Refuel(uint amountOfFuel)
        {
            if (Fuel + amountOfFuel > _fuelCapacity)
            {
                Fuel = _fuelCapacity;
            }
            else
            {
                Fuel += amountOfFuel;
            }
        }
        
        public Motorbike(double engineVolume, uint fuelCapacity, uint maxSpeed, Color color)
        {
            vehicleType = "Motorbike";
            EngineVolume = engineVolume;
            MaxSpeed = maxSpeed;
            Color = color;
            _fuelCapacity = fuelCapacity;
        }

        public Motorbike(double engineVolume, uint fuelCapacity, uint maxSpeed, Color color, string vehicle)
        {
            _fuelCapacity = fuelCapacity;
            EngineVolume = engineVolume;
            MaxSpeed = maxSpeed;
            Color = color;
            vehicleType = vehicle;
        }
    }
}
