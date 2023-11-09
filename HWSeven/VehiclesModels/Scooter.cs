using HWSeven.Contracts;

namespace HWSeven.VehiclesModels
{
    internal class Scooter : VehickesBase
    {
        public override void StopMoving()
        {
            Console.WriteLine("Самокат остановился");
        }

        public Scooter(string brand, double engVolume)
        {
            Brand = brand;
            EngineVolume = engVolume;
        }

        public Scooter(Scooter scooter)
        {
            Brand = scooter.Brand;
            EngineVolume = scooter.EngineVolume;
            Fuel = scooter.Fuel;
        }
    }
}
