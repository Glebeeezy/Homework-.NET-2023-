using HWSeven.Contracts;

namespace HWSeven.VehiclesModels
{
    internal class GasolineCar : VehickesBase
    {
        public override void StopMoving()
        {
            Console.WriteLine($"Машина остановилась");
        }

        public GasolineCar(string brand, double engVolume)
        {
            Brand = brand;
            EngineVolume = engVolume;
        }

        public GasolineCar(GasolineCar car)
        {
            Brand = car.Brand;
            EngineVolume = car.EngineVolume;
            Fuel = car.Fuel;
        }
    }
}
