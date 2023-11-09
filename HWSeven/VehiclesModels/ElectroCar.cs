using HWSeven.Contracts;

namespace HWSeven.VehiclesModels
{
    internal class ElectroCar : VehickesBase
    {
        public override void StopMoving()
        {
            Console.WriteLine($"Электро машина остановилась");
        }

        public ElectroCar(string brand, double engVolume)
        {
            Brand = brand;
            EngineVolume = engVolume;
        }

        public ElectroCar(ElectroCar car)
        {
            Brand = car.Brand;
            EngineVolume = car.EngineVolume;
            Fuel = car.Fuel;
        }
    }
}
