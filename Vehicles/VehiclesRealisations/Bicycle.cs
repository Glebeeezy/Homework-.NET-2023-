using System.Drawing;

namespace Vehicles.VehiclesRealisations
{
    internal class Bicycle
    {
        private readonly Motorbike _motorbike;

        private string _bicycleType;

        public string BicycleType
        {
            get { return _bicycleType; }
            init { _bicycleType = value; }
        }

        public void Refuel(uint ammountOfFood)
        {
            _motorbike.Refuel(ammountOfFood);
        }

        public void Move()
        {
            _motorbike.Move(_bicycleType);
        }

        public Bicycle(uint maxSpeed, uint energyPoolOfBicyclist, Color colorOfBike, string bicycleType)
        {
            _motorbike = new Motorbike(0, energyPoolOfBicyclist, maxSpeed, colorOfBike, "Bicycle");
            BicycleType = bicycleType;
        }
    }
}
