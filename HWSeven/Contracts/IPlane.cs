using HWSeven.PlanesModels;
using HWSeven.VehiclesModels;

namespace HWSeven.Contracts
{
    internal interface IPlane
    {
        public static string? Brand { get; set; }

        public int MaxAltitude { get; init; }

        public int MaxDistanceOfFlyght { get; init; }

        public void Takeoff()
        {
            Console.WriteLine($"Самолёт {Brand} взлетел");
        }

        public void Landing();

        public static object Clone(object cloneable)
        {
            if (cloneable is Airship airship)
            {
                Airship clone = new(airship);
                return clone;
            }
            if (cloneable is PistonPlane pistonPlane)
            {
                PistonPlane clone = new(pistonPlane);
                return clone;
            }
            if (cloneable is Jet jet)
            {
                Jet clone = new(jet);
                return clone;
            }
            else
            {
                throw new Exception("WrongTypeException");
            }
        }
    }
}
