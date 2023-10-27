using System.Drawing;
using Vehicles.VehiclesRealisations;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color color = Color.White;
            var car = new Car("Volvo", 100, 250, color);
            var motorbike = new Motorbike(1.5 , 100, 200, color);
            var bicycle = new Bicycle(25, 20, color, "Mountain bicycle");
            var horse = new Horse(45, 50, color, "Mustang", "Gleb");

            car.Refuel(50);
            car.Move();

            motorbike.Refuel(50);
            motorbike.Move();

            bicycle.Refuel(20);
            bicycle.Move(); 

            horse.Refuel(20);
            horse.Move();
        }
    }
}