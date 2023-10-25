using System.Drawing;
using Vehicles.Contracts;

namespace Vehicles.VehiclesRealisations
{
    internal class Horse : BaseVehicle
    {
        private uint _energy;
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

        public Horse(uint maxSpeed, uint stomachVolume, Color color)
        {
            vehicleType = "Horse";
            Color = color;
            StomachVolume = stomachVolume;
            MaxSpeed = maxSpeed;
        }
    }
}
