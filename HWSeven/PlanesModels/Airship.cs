using HWSeven.Contracts;

namespace HWSeven.PlanesModels
{
    internal class Airship : IPlane
    {
        public int MaxAltitude { get; init; }

        public int MaxDistanceOfFlyght { get; init; }

        public void Landing()
        {
            Console.WriteLine($"Дирижабль {IPlane.Brand} приземлился");
        }

        public Airship(int maxAltitude, int maxDistanceOfFlyght)
        {
            MaxAltitude = maxAltitude;
            MaxDistanceOfFlyght = maxDistanceOfFlyght;
        }

        public Airship(Airship clonable) 
        {
            MaxAltitude = clonable.MaxAltitude;
            MaxDistanceOfFlyght = clonable.MaxDistanceOfFlyght;
        }
    }
}
