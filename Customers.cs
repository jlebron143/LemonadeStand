using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Customers
    {
        double measurePercentage = 100;
        public double chanceOfMaxPurchase;
        double probabilityOfPurchase;
        public bool purchase;
        public int amountOfCupsBought;
        double temperaturePrediction;
        double statusPrediction;
        Random rnd;

        public Customers( double ChanceOfMaxPurchase, double AmountOfCupsBought)
        {
            chanceOfMaxPurchase = ChanceOfMaxPurchase;
            amountOfCupsBought = AmountOfCupsBought;

        }

        public void purchaseTemperatureProbablitity (Forecast forecast)
        {
            if( forecast.temperature <= 65)
            { }
        }


          

    }
}
