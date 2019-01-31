using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._01._19_hm
{
    class Program
    {
        static void Main(string[] args)
        {
            Game chess = new Game("chess", 2, 10 / 6f, "India");
            Game sudoku = new Game()
            {
                _name = "sudoku",
                _numberOfPlayers = 1,
                _originCountry = "France",
                _rating = 90f

            };
            Game soccer = new Game("soccer")
            {
                _numberOfPlayers = 22,
                _originCountry = "England",

            };
            Game basketball = new Game("basketball", "United States")
            {
                _numberOfPlayers = 10,
                _rating = 50 / 30,
            };
            PrintGame(soccer);

        }
        public static void PrintGame(Game g)
        {
            Console.WriteLine(g);
            int number = g.TellMeHowManyPlayers();
            Console.WriteLine($"There are:{number} players");
        }
    }
}
