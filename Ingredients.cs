using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Ingredients
    {
        public int numberOfPitchers;
        public int lemonsNeededFromInventory;
        public int addingSugarFromInventory;
        public int cupsNeededFromInventory;
        int amountOfLemonsNeeded;
        int amountOfSugarNeeded;
        int amountOfIceCubesNeeded;
        public int cupsForRecipe;

    }
    public pickIngredients()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        string userinput = Console.ReadLine().ToLower().ToUpper().
        switch (userinput)
        {
            case "Yes":
                PickNumberOfPitchers();
                break;
            case "No":
                CustomLemons();
                CustomSugar();
                CustomIceCubes();
                DisplayCustomIngredients();
                PickNumberOfPitchers();
                break;

            default:
                Console.WriteLine("");
                break;
        }
    }
    public int PickNumberOfPitchers()
    {
        Console.WriteLine("Things to think about");
        Console.WriteLine(" The 1st thing, the forecast for the day.(the hotter outside it is the more cups you might sell)");
        Console.WriteLine(" The 2nd thing , you can't save leftover lemonade to use the next day. \n\n");
        Console.WriteLine("How many pitchers do you want to make for the day?");
        try
        {
            int numberOfPitchers = int.Parse(Console.ReadLine());
            this.PickNumberOfPitchers = numberOfPitchers;
            return this.PickNumberOfPitchers;

        }
        catch (Exception)
        {
            Console.WriteLine("Stop right there! You must make less pitchers or go back to the store.");
            PickNumberOfPitchers();
            throw;
        }

    }

   public int CustomLemons()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        try
        {
            int.lemonsForIngredients = int.Parse(Console.ReadLine());
            return this.lemonsForIngredients = lemonsForIngredients;

        }
        catch (Exception)
        {

        }
    }
                 
        }
    }
       
}
