using TankFactory.Realisations;
using TankFactory.StaticFactory;

namespace TankFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeavyTank hevyTank = (HeavyTank)TankFabric.TankBaseCreate("HeavyTank");

            hevyTank.ShowTankType();

            hevyTank.Fire();

            hevyTank.StartEngine();

            hevyTank.StartMoving(10);

            hevyTank.TurnRight();

            hevyTank.StartMoving(15);

            hevyTank.StopEngine();

            Console.WriteLine($"{hevyTank.X} {hevyTank.Y}");

            MediumTank mediumTank = (MediumTank)TankFabric.TankBaseCreate("MediumTank");

            mediumTank.ShowTankType();

            mediumTank.Fire();

            mediumTank.StartEngine();

            mediumTank.TurnRight();

            mediumTank.StartMoving(15);

            mediumTank.TurnLeft();

            mediumTank.StartMoving(20);

            Console.WriteLine($"{mediumTank.X} {mediumTank.Y}");

            LightTank lightTank = (LightTank)TankFabric.TankBaseCreate("LightTank");

            lightTank.ShowTankType();

            lightTank.Fire();

            lightTank.StartEngine();

            lightTank.TurnRight();

            lightTank.StartMoving(15);

            lightTank.TurnLeft();

            lightTank.StartMoving(20);

            Console.WriteLine($"{lightTank.X} {lightTank.Y}");
        }
    }
}