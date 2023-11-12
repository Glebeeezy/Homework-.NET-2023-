using HWSeven.VehiclesModels;

namespace HWSeven.Contracts
{
    internal abstract class VehickesBase
    {
        public double EngineVolume { get; init; }

        public string Brand { get; init; }

        public int Fuel { get; set; }

        public void StartMoving()
        {
            Console.WriteLine($"Транспортное средство {Brand} начало движение");
        }

        public abstract void StopMoving();

        public static object Clone(object cloneable)
        {   
            if (cloneable is GasolineCar GasCar)
            {
                GasolineCar clone = new(GasCar);
                return clone;
            }
            if (cloneable is ElectroCar ElectCar)
            {
                ElectroCar clone = new(ElectCar);
                return clone;
            }
            if (cloneable is Scooter scooter)
            {
                Scooter clone = new(scooter);
                return clone;
            }
            else
            {
                throw new Exception("WrongTypeException");
            }
        }
    }
}
