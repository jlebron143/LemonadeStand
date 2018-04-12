using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new LemonadeStand.Game();
            game.RunGame();
            Console.ReadKey();
        }
    }
}
  