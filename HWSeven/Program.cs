using HWSeven.Contracts;
using HWSeven.VehiclesModels;

namespace HWSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GasolineCar ac = new GasolineCar("Renault", 12);
            object car = VehickesBase.Clone(ac);
            GasolineCar myCar = (GasolineCar)car;
            myCar.StartMoving();
            myCar.StopMoving();
        }
    }
}