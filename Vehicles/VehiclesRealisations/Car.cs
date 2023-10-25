using System.Drawing;
using Vehicles.Contracts;

namespace Vehicles.VehiclesRealisations
{
    internal class Car : BaseVehicle
    {
        protected uint _fuel;
        private readonly uint _fuelCapacity;
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            init { _brand = value; }
        }
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
        public override void Move()
        {
            if (Fuel > 2)
            {
                Console.WriteLine($"{vehicleType} {_brand} движется");
                Fuel -= 2;
            }
            else
            {
                Console.WriteLine($"{vehicleType} {_brand} не может двигаться так как не хватает топлива");
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

        public Car(string carBrand, uint fuelCapacity, uint maxSpeed, Color carColor)
        {
            if (carBrand == null)
            {
                throw new Exception("parametr carBrand cannot be null");
            }
            Brand = carBrand;
            _fuelCapacity = fuelCapacity;
            MaxSpeed = maxSpeed;
            Color = carColor;
            vehicleType = "Car";
        }    
    }
}
