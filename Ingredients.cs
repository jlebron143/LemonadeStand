using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ingredients
    {
        int amountOfLemonsNeeded = 8;
        int amountOfSugarNeeded = 1;
        int amountOfIceCubesNeeded = 20;
        public int cupsForIngredients = 7;
        public int numberOfPitchers;
        public int TakeOutLemonsFromInventory;
        public int TakeOutSugarFromInventory;
        public int TakeOutCupsFromInventory;


        public void PickIngredients()
        {
            Console.WriteLine("Read your ingredients to see what is used.");
            Console.WriteLine("The ingredients needed are 8 lemons, 1 cup of sugar and 20 cubes. This should make 7 cups of lemonade per pitcher. ");
            Console.WriteLine("Would you like to continue in making your lemonade? [Yes] or[No} ");
            string userinput = Console.ReadLine().ToLower().ToUpper();
            switch (userinput)
            {
                case "Yes":
                    PickNumberOfPitchers();
                    break;
                case "No":
                    CustomizeLemons();
                    CustomizeSugar();
                    CustomizeIceCubes();
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

        public int CustomizeLemons()
        {
            Console.WriteLine("Time to get to work . Add your lemons.");
            Console.WriteLine("How many lemons do you need?");
            try
            {
                int.amountOfLemonsNeeded = int.Parse(Console.ReadLine());
                return this.amountOfLemonsNeeded = amountOfLemonsNeeded;

            }
            catch (Exception)
            {
                Console.WriteLine("You must enter a valid number.");
                CustomizeLemons();
                throw;
            }
        }
        public int CustomizeSugar()
        {
            Console.WriteLine("Please enter in the amount of sugar you would like to add?");
            try
            {
                int amountOfSugarNeeded = int.Parse(Console.ReadLine());
                return this.amountOfSugarNeeded = amountOfSugarNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Please type in a valid number.");
                CustomizeSugar();
                throw;
            }

        }
        public int CustomizeIceCubes()
        {
            Console.WriteLine("Please type in the amount of ice you would like to add.");
            try
            {
                int amountOfIceCubesNeeded = int.Parse(Console.ReadLine());
                return this.amountOfIceCubesNeeded = amountOfIceCubesNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Please type in a valid number.");
                CustomizeIceCubes();
                throw;
            }
        }
        public void DisplayCustomIngredients()
        {
            Console.WriteLine("You picked out {0} lemons, {1} cups of sugar, {2} ice cubes. This will make {3} cups of Lemonade per pitcher");

        }
        public int BringOutSugar()
        {
            try
            {
                TakeOutSugarFromInventory = numberOfPitchers * amountOfSugarNeeded;
                return TakeOutSugarFromInventory;

            }
            catch (Exception)
            {
                Console.WriteLine("Stop right there! You're short on sugar. You need to start from the beginning");
                PickIngredients();
                throw;
            }
        }
        public int BringOutLemons()
        {
            try
            {
                TakeOutLemomsFromInventory = numberOfPitchers * amountOflemonsNeeded;
                return TakeOutLemonFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Stop right there! Looks like you're short on lemons. Go back start from the beginning.");
                PickIngredients();
                throw;
            }
        }
        public int BringOutIceCubes()
        {
            try
            {
                TakeOutIceCubesFromInventory = numberOfPitchers * iceCubesForIngredients;
                return TakeOutIceCubesFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Stop right there! You need more ice cubes. Start fromt the beginning.");
                PickIngredients();
                throw;
            }
        }
        public void BringOutCups()
        {
            try
            {
                TakeOutCupsFromInventory = numberOfPitchers * cupsForIngredients;
                return TakeOutCupsFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Hold up! You're running short. Start over.");
                PickIngredients();
                throw;
            }
        }
    }
}


