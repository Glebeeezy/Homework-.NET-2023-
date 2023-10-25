using System.Drawing;

namespace Vehicles.Contracts
{
    public abstract class BaseVehicle
    {
        protected string vehicleType = "unknown";
        public uint MaxSpeed { get; init; }
        public abstract uint Fuel { get; protected set; }
        public Color Color { get; set; }

        public virtual void Move()
        {
            if (Fuel > 2)
            {
                Console.WriteLine($"{vehicleType} движется");
                Fuel -= 2;
            }
            else
            {
                Console.WriteLine($"{vehicleType} не может двигаться");
            }
        }

        public abstract void Refuel(uint amountOfFuel);
    }
}
