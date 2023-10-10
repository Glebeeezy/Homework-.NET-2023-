using TankFactory.Contracts;
using TankFactory.Enums;

namespace TankFactory
{
    internal partial class LightTank : TankBase
    {
        public override void StartMoving(int timeOfMoivng)
        {
            if (_engineIsRunning)
            {
                _isMoving = true;

                if (_direction == Direction.straight && _isMoving)
                {
                    for (int i = 0; i < timeOfMoivng; i++)
                    {
                        Y = Y + _speed;
                    }
                    StopMoving();
                }
                else if (_direction == Direction.right && _isMoving)
                {
                    for (int i = 0; i < timeOfMoivng; i++)
                    {
                        X = X + _speed;
                    }
                    StopMoving();
                }
                else if (_direction == Direction.left && _isMoving)
                {
                    for (int i = 0; i < timeOfMoivng; i++)
                    {
                        X = X - _speed;
                    }
                    StopMoving();
                }
                else if (_direction == Direction.back && _isMoving)
                {
                    for (int i = 0; i < timeOfMoivng; i++)
                    {
                        Y = Y - _speed;
                    }
                    StopMoving();
                }
            }
            else
            {
                Console.WriteLine("Танк не заведён");
            }
        }

        public LightTank(string tankType)
        {
            TankType = tankType;
        }
    }    
}
