using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankFactory.Contracts;
using TankFactory.Realisations;

namespace TankFactory.StaticFactory
{
    internal class TankFabric
    {
        public static TankBase? TankBaseCreate(string tankType)
        {
            if (!string.IsNullOrEmpty(tankType) && tankType == "MediumTank")
            {
                MediumTank tank = new MediumTank(tankType);
                return tank;
            }

            else if(!string.IsNullOrEmpty(tankType) && tankType == "LightTank")
            {
                LightTank tank = new LightTank(tankType);
                return tank;
            }

            else if(!string.IsNullOrEmpty(tankType) && tankType == "HeavyTank")
            {
                HeavyTank tank = new HeavyTank(tankType);
                return tank;
            }

            else
            {
                Console.WriteLine("Указан неверный тип танка");
                return null;
            }
        }
    }
}
