using HWSeven.Contracts;

namespace HWSeven.PlanesModels
{
    internal class Jet : IPlane
    {
        public int MaxAltitude { get; init; }

        public int MaxDistanceOfFlyght { get; init; }

        public void Landing()
        {
            Console.WriteLine($"Рекативный самолёт {IPlane.Brand} приземлился");
        }

        public Jet(int maxAltitude, int maxDistanceOfFlyght)
        {
            MaxAltitude = maxAltitude;
            MaxDistanceOfFlyght = maxDistanceOfFlyght;
        }

        public Jet(Jet clonable)
        {
            MaxAltitude = clonable.MaxAltitude;
            MaxDistanceOfFlyght = clonable.MaxDistanceOfFlyght;
        }
    }
}
