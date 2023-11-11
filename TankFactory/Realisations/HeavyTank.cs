using TankFactory.Contracts;
using TankFactory.Enums;

namespace TankFactory.Realisations
{
    internal sealed class HeavyTank : TankBase
    {
        private new int _speed = 20;

        public override void Fire()
        {
            Console.WriteLine("Бабах");
        }

        public override void StartMoving(int timeOfMoivng)
        {
            if (_engineIsRunning)
            {
                _isMoving = true;

                if (_direction == Direction.straight && _isMoving)
                {
                    MoveStraight(timeOfMoivng);
                }
                else if (_direction == Direction.right && _isMoving)
                {
                    MoveRight(timeOfMoivng);
                }
                else if (_direction == Direction.left && _isMoving)
                {
                    MoveLeft(timeOfMoivng);
                }
                else if (_direction == Direction.back && _isMoving)
                {
                    MoveBack(timeOfMoivng);
                }
            }
            else
            {
                Console.WriteLine("Танк не заведён");
            }
        }

        private void MoveStraight(int timeOfMoving)
        {
            for (int i = 0; i < timeOfMoving; i++)
            {
                Y = Y + _speed;
            }
            StopMoving();
        }

        private void MoveRight(int timeOfMoving)
        {
            for (int i = 0; i < timeOfMoving; i++)
            {
                X = X + _speed;
            }
            StopMoving();
        }

        private void MoveLeft(int timeOfMoving)
        {
            for (int i = 0; i < timeOfMoving; i++)
            {
                X = X - _speed;
            }
            StopMoving();
        }

        private void MoveBack(int timeOfMoving)
        {
            for (int i = 0; i < timeOfMoving; i++)
            {
                Y = Y - _speed;
            }
            StopMoving();
        }

        public void ShowTankType()
        {
            Console.WriteLine(TankType);
        }

        public HeavyTank(string tankType)
        {
            TankType = tankType;
        }
    }
}
