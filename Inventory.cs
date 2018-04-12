using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        List<Lemons> lemons = new List<Lemons>();
        List<Sugar> sugar = new List<Sugar>();
        List<IceCubes> iceCubes = new List<IceCubes>();
        List<Cups> cups = new List<Cups>();

        public void LemonsRequired(int AmountOfLemonsNeeded)
        {
            for (int i = 0; i < AmountOfLemonsNeeded; i++)
            {
                Lemons lemon = new Lemons();
                lemons.Add(lemon);
            }
            Console.WriteLine("Right now you have {0} lemons. \n\n", lemons.Count);
        }

        public void SubtractLemons(Player player)
        {
            try
            {
                int discardLemons = player.ingredients.BringOutLemons();
                for (int i = 0; i < discardLemons; i++)
                {
                    lemons.RemoveAt(0);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Oh no! It seems like you need to make some changes to the ingredients. Start over.");
                player.ingredients.PickIngredients();
                throw;
            }
        }
        public void SubmitSugar(int amountOFSugarNeeded)
        {
            for (int i = 0; i < amountOFSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine("You are buying {0} cups fo Sugar.", sugar.Count);

        }
        public void SubstractSugar(Player player)
        {
            try
            {
                int discardSugar = player.ingredients.BringOutSugar();
                for (int i = 0; i < discardSugar; i++)
                {
                    sugar.RemoveAt(0);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Oh no! It seems like you need to make some changes to the ingredients. Start over.");
                player.ingredients.PickIngredients();
            }
        }
        public void submitIceCubes(int AmountOfIceCubesNeeded)
        {
            for (int i = 0; i < AmountOfIceCubesNeeded; i++)
            {
                IceCubes iceCubes = new IceCubes();
                this.iceCubes.Add(iceCubes);
            }
            Console.WriteLine("Right now you have {0} of ice .", iceCubes.Count);
        }
        public void SubstractIceCubes(Player player)

        {
            try
            {
                int discardIceCubes = player.ingredients.BringOutIceCubes();
                for (int i = 0; i < discardIceCubes; i++)
                {
                    iceCubes.RemoveAt(0);

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Oh no! It seems like you need to make some changes to the ingredients. Start over.");
                player.ingredients.PickIngredients();
                throw;
            }
        }
        public void submitCups(int AmountOfCupsNeeded)

        {
            for (int i = 0; i < AmountOfCupsNeeded; i++)
            {
                Cups cups = new Cups();
                this.cups.Add(cups);
            }
        }
        public void SubstractCups(Player player)
        {
            try
            {
                int discardCups = player.ingredients.BringOutCups();
                for (int i = 0; i < discardCups; i++)
                {
                    cups.RemoveAt(0);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Oh no! It seems like you need to make some changes to the ingredients. Start over.");
                player.ingredients.PickIngredients();
                throw;
            }
        }
        public void DisplayAllOfInventory()
        {
            Console.WriteLine("Right now, you have {0} lemons. ", lemons.Count);
            Console.WriteLine("Right now , you have {0} cups of sugar", sugar.Count);
            Console.WriteLine("Right now, you have {0} ice cubes", iceCubes.Count);
            Console.WriteLine("Right now, you have {0} cups.", cups.Count);
        }
        public void ReturnItemsBackInInventory(Player player)
        {
            SubtractLemons(player);
            SubstractSugar(player);
            SubstractIceCubes(player);
            SubstractCups(player);
        }
    }
}
