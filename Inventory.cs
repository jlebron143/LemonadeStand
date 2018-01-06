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

    public LemonsRequired(int AmountOfLemonsNeeded )
        {
            for(int i= 0, i < AmountOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine("Right now you have {0} lemons. \n\n", lemons.Count);
        }

        public SubtractLemons(Player player)
        {
            try
            {
                int discardLemons = player.ingredients.BringOutLemons();
                for(int i = 0; i < discardLemons; i++)
                {
                    lemons.RemoveAt(0);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Oh no! It seems like you need to make some changes to the ingredients. Start over.");
                player.recipe.PickIngredients();
                throw;
            }
        }
        public SubmitSugar(int 

    }
}
