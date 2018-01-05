using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Game
    {
        public Random random;
        public Forecast forecast;
        public Player player;
        public Booth booth;
        public Day day;
        public int randomValue;

        public Game ()

        {
            random = new Random();
            forecast = new Forecast(random);
            player = new Player();
            booth = new Booth();
            day = new Day(random);

    }
        public RunGame()
        {
            day.CreateCustomers();
            RandomNumber();
            DisplayOpeningStatement();
            day.SellLemonade(player);     

        }

        public DisplayOpeningStatement()
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

        public MakeForecast()
        {
            day.forecast.CreateTodaysForecast();
        }

        public MainMenu()
        {
            Console.WriteLine("Please submit the number of menu items you need.");
            Console.WriteLine("1: Rules\n\n 2:Forecast\n\n 3:Check Funds\n\n 4:go to the store\n\n 5:Check inventory\n\n 6:Look at Lemonade recipe.");
            string value = Console.ReadLine();
            switch (value)
            {
                case "1":
                    Console.Clear();
                    DisplayInstructions(); 

                    break;

                case "2":
                    Console.Clear();
                    day.forecast.DisplayTodayForecast();
                    day.forecast.CreateForecast();
                    Console.WriteLine("Press[enter] to go to main menu");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                    case "3";
                    Console.Clear();
                    player.funds.DisplayBalance();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                    case "4":
                    Console.Clear();
                    store.restock(player);
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                    case "5":
                    Console.Clear();
                    player.inventory.DisplayAllInventory();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                    case "6":
                    Console.Clear();
                    player.inventory.DisplayAllProductInventory();
                    player.recipe.PickRecipe();
                    player.inventory.RemoveItemAfterLemonadeIsMade(player);
                    Console.WriteLine("Right now you now have {0} cups of lemonade!!", (player.recipe.numberOfPitchers * player.recipe.cupsForRecipe));
                    day.CalculatingWhenToStopSell(player);
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                case "7":
                    Console.Clear();
                    day.PriceOfCup();
                    player.Wallet.thisWeekEarnings();
                    Console.ReadLine();
                    RestartGame();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Our apologies, we do not have that available. \n\n");
                    MainMenu();
                    break;

                   public void RestartGame()
        {
            Console.WriteLine("Would you like play again? [Y] or [N]");
            string answer = Console.ReadLine().ToUpper();
            switch (answer)
            {
                case "Y":
                    DisplayWelcome();
                    break;
                case "N":
                    Environment.Exit(0);
                    break;
                    Console.WriteLine("Sorry, that we don't have an option for that.\n\n");
                    break;

            }
        }
        public int RandomNumber()
        {
            return randomValue = random.Next(1, 100);
        }













    }
          
                
        }
}
