﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Customers
    {
       
        public double chanceOfMaxPurchase;
        public int amountOfCupsBought;

        public bool purchase;
        double probabilityOfPurchase;
        double investmentPrediction;
        
        double temperaturePrediction;
        double statusPrediction;
        Random rnd;
        double measurePercentage = 100;

        public Customers( double ChanceOfMaxPurchase, double AmountOfCupsBought)
        {
            chanceOfMaxPurchase = ChanceOfMaxPurchase;
            amountOfCupsBought = AmountOfCupsBought;

        }
        public void purchaseStatusProbablitity(Forecast forecast)
        {
            if (forecast.status == "sunny")
            {
                statusPrediction = measurePercentage - .85;
            }
            else if (forecast.status == "Cloudy" || forecast.status == "foggy")
            {
                temperaturePrediction = measurePercentage - .50;

            }
            else if (forecast.status == "rainy" || forecast.status == "furries")
            {
                temperaturePrediction = measurePercentage - .25;

            }
        }

        public void purchaseTemperatureProbablitity (Forecast forecast)
        {
            if( forecast.temperature <= 65)
            {
                temperaturePrediction = measurePercentage - .50;
            }
            else if (forecast.temperature >= 75)
            {
                temperaturePrediction = measurePercentage - .75;

            }
        }
       
        public void probablitityTopurchase(Everyday day)
        {
            if (day.probabilityToPurchase == .50)
            {
                investmentPrediction = measurePercentage - .85;
            }
            else if (day.probabilityToPurchase == .75)
            {
                investmentPrediction = measurePercentage - .50;

            }
            else if (day.probabilityToPurchase == 1.00)
            {
                investmentPrediction = measurePercentage - .25;

            }
            else if (day.probabilityToPurchase == 1.25)
            {
                investmentPrediction = measurePercentage - .15;

            }
        }










    }
}
