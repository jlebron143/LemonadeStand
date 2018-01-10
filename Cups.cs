using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Cups :Iprofit
    {
        private double priceOfCups = .15;
        private string nameCups;

        public double pullCost()
        {
            return priceOfCups;
        }
        public void makeCupsName()
        {
            nameCups = "Cups";
        }
        public string pullNameOfCups()
        {
            return nameCups;
        }
    }
}
