using TankFactory.Contracts;

namespace TankFactory
{
    internal partial class LightTank : TankBase
    {
        private new int _speed = 65;

        public override void Fire()
        {
            Console.WriteLine("Бдыщь");
        }

        public void ShowTankType()
        {
            Console.WriteLine(TankType);
        }
    }
}
