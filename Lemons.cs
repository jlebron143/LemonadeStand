using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemons
    {
        private double priceOfLemons = .15;
        private string callFruit;

   public double TellLemonCost()
        {
            return priceOfLemons;
        }
     public void makeLemonWord ()
        {
            callFruit = "Lemon";
        }
    public string giveLemonName()
        {
            return callFruit;
        }
    }
}
