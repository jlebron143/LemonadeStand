using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Money
    {
        //double is used for decimals; 64-bit
        public double startingFunds = 12.00;
        double productsPurchased;
        double productCost;
        bool shortFunds;

        public void ShowCurrentBal()
        {
            Console.WriteLine(startingFunds);
        }
        public bool checkShortFunds()
        {
            if(startingFunds < productCost)
            {
                shortFunds = true;
                Console.WriteLine("Oh no! Looks like you're short on funds. ");
            }
            return shortFunds;
        }
      
    }
    public double transactionOnProducts(double productCost)
    {
        productsPurchased = startingFunds - productCost;
        Console.WriteLine("Product purchase is completed!");
        startingFunds = productsPurchased;
        return startingFunds;

    }
    public void weeklyProfit ()
    {
        double profit;
        double beginningInvestment = 12.00;
        profit = startingFunds - beginningInvestment;
        Console.WriteLine("This week you have made {0} in profit!");
        
    }
}
