﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class IceCubes
    {
        double priceOfIceCubes = .10;
        string nameIceCubes;

        public double pullIceCubesPrice()
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
