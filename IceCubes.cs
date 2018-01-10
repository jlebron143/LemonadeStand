using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class IceCubes : Iprofit
    {
        double priceOfIceCubes = .10;
        string nameIceCubes;

        public double pullCost()
        {
            return priceOfIceCubes;
        }
        public void makeIceCubesName()
        {
            nameIceCubes = "Ice Cubes";
        }
        public string pullIceCubesName()
        {
            return nameIceCubes;
        }
    }
}
