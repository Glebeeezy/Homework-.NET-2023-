using System.Drawing;
using Vehicles.Contracts;

namespace Vehicles.VehiclesRealisations
{
    internal class Horse : BaseVehicle
    {
        private uint _energy;
        public string Breed { get; init; }
        public string Name { get; init; }
        public uint StomachVolume { get; init; }
        public override uint Fuel 
        { 
            get
            {
                return _energy;
            } 
            protected set 
            {
                _energy = value;
            }
        }

        public override void Refuel(uint kilocalories)
        {
            if (Fuel + kilocalories > StomachVolume)
            {
                Fuel = StomachVolume;
            }
            else
            {
                Fuel += kilocalories;
            }
        }

        public Horse(uint maxSpeed, uint stomachVolume, Color color, string breed, string name)
        {
            Name = name;
            Breed = breed;
            vehicleType = "Horse";
            Color = color;
            StomachVolume = stomachVolume;
            MaxSpeed = maxSpeed;
        }
    }
}
