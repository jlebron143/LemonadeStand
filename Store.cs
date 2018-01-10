using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        double getLemons;
        double getSugar;
        double getIceCubes;
        double getCups;

        public void GroceryShop(Player player)
        {
            Console.WriteLine(" Have you looked at your list yet? You should needs lemons, sugar, ice cubes and cups. Get what you need.");

            string stockUp = Console.ReadLine().ToLower();
            switch (stockUp)
            {
                case "Lemons":
                    GrabLemons(player);
                    break;
                case "Sugar":
                    GrabSugar(player);
                    break;
                case "Ice Cubes":
                    GrabIceCubes(player);
                    break:
                case "Cups":
                    GrabCups(player);
                    break;
                default:
                    Console.WriteLine("That's not on your list! Put that back!");
                    GroceryShop(player);
                    break;

            }
        }
        public int AmountOfLemonsNeeded(Player player)
        {
            Console.WriteLine(" The price of lemons are .15 cents each. \n\n");
            Console.WriteLine(" How many do you need?\n\n\");
                try
            {
                int lemonsNeeded = int.Parse(Console.ReadLine();
                return lemonsNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Invaild! Type in correct number. \n\n");
                GroceryShop(player;
                throw;
            }

        }
        public double amountOfPurchasedLemons(int lemonsNeededToBuy)
        {
            Lemons lemon = new Lemons();
            getLemons = lemon.pullCost() * lemonsNeededToBuy;
            return getLemons;
        }
        public void buyLemons(Player player)
        {
            if (player.money.checkShortFunds(getLemons))
            {
                GroceryShop(player);
            }
            else
            {
                player.money.purchaseProducts(getLemons);

            }
        }
        public lemonsCheckOut(Player player)
        {
            int amountOfLemons = AmountOfLemonsNeeded(player);
            amountOfPurchasedLemons(amountOfLemons);
            buyLemons(player);
            player.inventory.LemonsRequired(amountOfLemons);
            Console.WriteLine("");
            GroceryShop(player);
        }
        public int amountOfSugarNeeded(Player player)
        {
            Console.WriteLine(" Every cup of sugar cost .50  cents. \n\n");
            Console.WriteLine("How many cups of sugar do you need to buy today? \n\n\");
           try
            {
                int sugarNeeded = int.Parse(Console.ReadLine());
                return sugarNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Invaild! Type in the correct number");
                GroceryShop(player);
                throw;
            }

        }
        public double amountOfSugarPurchased(int sugarNeededToBuy)
        {
            Sugar sugar = new Sugar();
            getSugar = sugar.pullCost() * sugarNeededToBuy;
            return getSugar;
        }
        public void buySugar(Player player)
        {
            if (player.money.checkShortFunds(getSugar))
            {
                GroceryShop(player);

            }
            else
            {
                player.money.purchaseProducts(getSugar);
            }
        }
        public void sugarCheckOut(Player player)
        {
            int amountOfSugar = amountOfSugarNeeded(player)
            amountOfSugarPurchased(amountOfSugar);
            buySugar(player);
            player.inventory.SugarRequired(amountOfSugar);
            GroceryShop(player);
        }
        public void amountOfSugarNeeded(Player player)
        {
            Console.WriteLine("They have ice cubes at .10 cents.");
            Console.WriteLine("How many ice cubes do you need today?");
            try
            {
                int iceCubesNeeded = int.Parse(Console.ReadLine());
                return iceCubesNeeded;

            }
            catch (Exception)
            {
                Console.WriteLine("Stop! That is an invaild entry. Try again.");
                GroceryShop(player);
                throw;
            }
        }
        public double amountOfIceCubesPurchased( int iceCubesNeededToBuy)
        {
            IceCubes iceCubes = new IceCubes;
            getIceCubes = iceCubes.pullCost() * iceCubesNeededToBuy;
            return getIceCubes;
        }
                
            }
    public void buyIceCubes(Player player)
    {
        if (player.money.checkShortFunds(getIceCubes))
        {
            GroceryShop(player);

        }
        else
        {
            player.money.purchaseProduct(getIceCubes);

        }
       
    }
    public void iceCubesCheckOut (Player player)
    {
        int amountOfIceCubes = amountOfIceCubesNeeded(player);
        amountOfIceCubesPurchased(amountOfIceCubes);
        buyIceCubes(player);
        player.inventory.IceCubesRequired(amountOfIceCubes);
        GroceryShop(player);
    }
        }

        }
        }
        }
    }
}
