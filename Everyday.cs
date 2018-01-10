using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Everyday
    {
        public Customers customer;
        public Forecast forecast;
        int dailyCustomerTraffic = 40;
        public double stopLemonade;
        int userInput;
        double sell;
        double profitsEarned;
        public double probabilityToPurchase;
        Random rnd;
        public double priceOfCups;
        int amountOfCupsBought;

        //create list for cost,customer,and cups

        List<int> amountOfCupsCustomer = new List<int> { 1, 2, 3, 1, 1, 3, 2 };
        List<double> cupsPriceAgreement = new List<double> { .50, .75, 1.00, 1.25, 1.75 };
        public List<Customers> customers = new List<Customers>();

        public Everyday(Random rnd)
        {
            forecast = new Forecast(rnd);
            this.rnd = rnd;
        }
        public double cupPrice()
        {
            Console.WriteLine("You need to set your price for each cup of lemonade. ");
            try
            {
                double.priceOfCups = double.Parse(Console.ReadLine());
                this.priceOfCups = priceOfCups;
                return this.priceOfCups;
            }
            catch (Exception)
            {
                Console.WriteLine("");
                cupPrice();
                throw;

            }
        }

        public double CustomerBuyingLemonade()
        {
            int customersProbablityToPurchase = rnd.Next(0, amountOfCupsCustomer.Count);
            probabilityToPurchase = amountOfCupsCustomer[customersProbablityToPurchase];
            return probabilityToPurchase;


        }
        public int CustomersDesireForPurchase()
        {
            int howManyamountOfCupsBought = rnd.Next(0, cupsPriceAgreement.Count);
            amountOfCupsBought = cupsPriceAgreement[howManyamountOfCupsBought];
            return amountOfCupsBought;
        }
        public void makeCustomers()
        {
            for (int i = 0; i < dailyCustomerTraffic; i++)
            {
                int amountOfCups = CustomersDesireForPurchase();
                double amountToPay = CustomerBuyingLemonade();
                Customers customer = new Customers(moneyToPay, howManyCups);
                customers.Add(customer);
            }
        }
        public double TimeForLemonadeSell(Player player)
        {
            for (int i = 0; i < stopLemonade; i++)
            {
                if (customers[i].purchase == true)
                {
                    sell = priceOfCups;
                    player.money.startingFunds += sell;
                    profitsEarned = sell * stopLemonade;

                }
            }
            Console.WriteLine("You make a profit of {0}!", profitsEarned);
            return player.money.startingFunds;
        }
        public void endOfSaleCalcuations(Player player)
        {
            stopLemonade = player.ingredients.cupsForIngredients * player.ingredients.numberOfPitchers;

        }
    }
}


    }
}
