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
        public int TakeOutLemonsFromInventory;
        public int TakeOutSugarFromInventory;
        public int TakeOutCupsFromInventory;
        int amountOfLemonsNeeded;
        int amountOfSugarNeeded;
        int amountOfIceCubesNeeded;
        public int cupsForIngredients;

    }
    public void PickIngredients()
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
            Console.WriteLine("You must enter a valid number.");
            CustomLemons();
            throw;
        }
    }
    public int CustomSugar()
        {
        Console.WriteLine("Please enter in the amount of sugar you would like to add?");
        try
        {
            int sugarForLemonade = int.Parse(Console.ReadLine());
            return this.sugarForLemonade = sugarForLemonade;
        }
        catch(Exception)
        {
            Console.WriteLine.("Please type in a valid number.");
            CustomSugar();
            throw;
        }  
        
    }
    public int MakeCustomIceCubes()
    {
        Console.WriteLine("Please type in the amount of ice you would like to add.");
        try
        {
            int iceCubesForLemonade = int.Parse(Console.ReadLine());
            return this.iceCubesForLemonade = iceCubesForLemonade;
        }
        catch (Exception)
        {
            Console.WriteLine("Please type in a valid number.");
            CustomIceCubes();
            throw;
        }
}
    public void DisplayCustomIngredients ()
    {
        Console.WriteLine("Please type in a valid number.");

    }
     public int BringOutSugar()
    {
        try
        {
            TakeOutSugarFromInventory = numberOfPitchers * sugarForIngredients;
            return TakeOutSugarFromInventory;

        }
        catch(Exception)
        {
            Console.WriteLine("Stop right there! You're short on sugar. You need to start from the beginning");
            PickIngredients();
            throw;
        }
        public int BringOutLemons()
    {
        try
        {
            TakeOutLemomsFromInventory = numberOfPitchers * lemonsForIngredients;
            return TakeOutLemonFromInventory;
        }
        catch(Exception)
        {
            Console.WriteLine("Stop right there! Looks like you're short on lemons. Go back start from the beginning.");
            PickIngredients();
            throw;
        }
        public int BringOutIceCubes()
    {
        try
        {
            TakeOutIceCubesFromInventory = numberOfPitchers * iceCubesForIngredients;
            return TakeOutIceCubesFromInventory;
        }
        catch(Exception)
        {
            Console.WriteLine("Stop right there! You need more ice cubes. Start fromt the beginning.");
            PickIngredients();
            throw;
        }
    }
    public int BringOutCups()
    {
        try
        {
            TakeOutCupsFromInventory = numberOfPitchers * cupsForIngredients;
            return TakeOutCupsFromInventory;
        }
        catch(Exception)
        {
            Console.WriteLine("Hold up! You're running short. Start over.");
            PickIngredients();
            throw;
        }
    }
 }


} 
