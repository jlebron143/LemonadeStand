using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        
        public Forecast forecast;
        public Store store;
        public Everyday day;
        public Player player;
        public Random rnd;
        public int randomValue;

        public Game()

        {
            rnd = new Random();
            forecast = new Forecast(rnd);
            player = new Player();
            store = new Store ();
            day = new Everyday(rnd);

        }
        public void RunGame()
        {
            day.makeCustomers();
            RandomNumber();
            DisplayOpeningStatement();
            day.TimeForLemonadeSell(player);

        }

        public void DisplayOpeningStatement()
        {
            Console.WriteLine("Knowing that you have a passion for entrepreneurship, I figured over the next week you'll be trying to make as much of a profit as possible");
            Console.WriteLine("With only $10.00 in your pocket, I suggest starting a lemonade stand to make a simple profit.");
            Console.WriteLine("Let's take your $10.00 and use it to buy the ingredients you need from the store. This lemonade isn't going to make itself.");
            Console.WriteLine("Press [enter] to get to the Main Menu.");
            Console.ReadLine;
            Console.Clear;
            MakeForecast();
            MainMenu();
        }

        public void MakeForecast()
        {
            day.forecast.MakeDailyForecast();
        }

        public void MainMenu()
        {
            Console.WriteLine("Please submit the number of menu items you need.");
            Console.WriteLine("1: Rules\n\n 2:Forecast\n\n 3:Check Funds\n\n 4:go to the store\n\n 5:Check inventory\n\n 6:Look at Lemonade recipe.");
            string value = Console.ReadLine();
            switch (value)
            {
                case "1":
                    Console.Clear();
                    DisplayRules();

                    break;

                case "2":
                    Console.Clear();
                    day.forecast.MakeDailyForecast();
                    day.forecast.MakeTomorrowsForecast();
                    Console.WriteLine("Press[enter] to go to main menu");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                case "3":
                    Console.Clear();
                    player.money.ShowCurrentBal();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                case "4":
                    Console.Clear();
                    store.GroceryShop(player);
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                case "5":
                    Console.Clear();
                    player.inventory.DisplayAllOfInventory();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                case "6":
                    Console.Clear();
                    player.inventory.DisplayAllOfInventory();
                    player.ingredients.PickIngredients();
                    player.inventory.ReturnItemsBackInInventory(player);
                    Console.WriteLine("Right now you now have {0} cups of lemonade!!", (player.ingredients.numberOfPitchers * player.ingredients.cupsForRecipe));
                    day.endOfSaleCalcuations(player);
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                case "7":
                    Console.Clear();
                    day.cupPrice();
                    player.money.weeklyProfit();
                    Console.ReadLine();
                    RestartGame();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Our apologies, we do not have that available. \n\n");
                    MainMenu();
                    break;
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand! Today , you will be receiving a kickstart as to have a successful lemonade stand.");
            Console.WriteLine("Are you ready? Here are the rules.");
            Console.WriteLine("Everyday you need to check the forecast to predict how you day will turn out for profit.");
            Console.WriteLine(" Next, you need to check your inventory to make your there is no shortage on your ingredients.");
            Console.WriteLine("Then,you need to determine how many batches of lemonade you are going to make for the day based on your prediction. ");
            Console.WriteLine("Please keep in mind that you make too much lemonade, you are NOT able to save the leftovers for the following day.");
            Console.WriteLine("Once you have checked everything off your list , open up and start selling.");
            Console.WriteLine("At the time of closing up your stand, you will be able to tally up your profit for the day.");
            Console.WriteLine("Your profit for the day will determine how much you have invest fot your lemonade for the following day.");
            Console.WriteLine("So spend and manage your money well.");
            Console.WriteLine("GoodLuck!");
        }
                

        public void RestartGame()
        {
            Console.WriteLine("Would you like play again? [Yes] or [No]");
            string answer = Console.ReadLine().ToUpper().ToLower();
            switch (answer)
            {
                case "Y":
                    DisplayOpeningStatement();
                    break;
                case "N":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry, that we don't have an option for that.\n\n");
                    break;

            }
        }
        public int RandomNumber()
        {
            return randomValue = rnd.Next(1, 100);
        }
    }
}













