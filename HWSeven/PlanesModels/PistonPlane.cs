using HWSeven.Contracts;

namespace HWSeven.PlanesModels
{
    internal class PistonPlane : IPlane
    {
        public int MaxAltitude { get; init; }

        public int MaxDistanceOfFlyght { get; init; }

        public void Landing()
        {
            Console.WriteLine($"Поршневой самолёт {IPlane.Brand} приземлился");
        }

        public PistonPlane(int maxAltitude, int maxDistanceOfFlyght)
        {
            MaxAltitude = maxAltitude;
            MaxDistanceOfFlyght = maxDistanceOfFlyght;
        }

        public PistonPlane(PistonPlane clonable)
        {
            MaxAltitude = clonable.MaxAltitude;
            MaxDistanceOfFlyght = clonable.MaxDistanceOfFlyght;
        }
    }
}
