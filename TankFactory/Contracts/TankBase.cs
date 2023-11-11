using System;
using TankFactory.Enums;

namespace TankFactory.Contracts
{
    internal abstract class TankBase
    {
        protected Direction _direction = Direction.straight;

        private string _tankType;

        protected string TankType
        {
            get { return _tankType; }
            init { _tankType = value; }
        }


        protected bool _engineIsRunning = false;

        protected bool _isMoving = false;

        protected int _speed = 10;

        private int _x;

        public int X
        {
            get { return _x; }
            protected set { _x = value; }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            protected set { _y = value; }
        }

        public void StartEngine()
        {
            if (!_engineIsRunning)
            {
                _engineIsRunning = true;
            }
        }

        public void StopEngine()
        {
            if (_engineIsRunning)
            {
                _engineIsRunning = false;
            }
        }

        public abstract void StartMoving(int timeOfMoivng);

        protected void StopMoving()
        {
            _isMoving = false;
        }

        public void TurnLeft()
        {
            if (_engineIsRunning)
            {
                if (_direction == Direction.straight)
                {
                    _direction = Direction.left;
                }
                else if (_direction == Direction.right)
                {
                    _direction = Direction.straight;
                }
                else if (_direction == Direction.left)
                {
                    _direction = Direction.back;
                }
                else if (_direction == Direction.back)
                {
                    _direction = Direction.right;
                }
            }
            else
            {
                Console.WriteLine("Двигатель не заведён");
            }
        }

        public void TurnRight()
        {
            if (_engineIsRunning)
            {
                if (_direction == Direction.straight)
                {
                    _direction = Direction.right;
                }
                else if (_direction == Direction.right)
                {
                    _direction = Direction.back;
                }
                else if (_direction == Direction.left)
                {
                    _direction = Direction.straight;
                }
                else if (_direction == Direction.back)
                {
                    _direction = Direction.left;
                }
            }
            else
            {
                Console.WriteLine("Двигатель не заведён");
            }
        }

        public abstract void Fire();


    }
}
