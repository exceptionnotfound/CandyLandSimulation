using CandyLandSimulation.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            
            DisplayOptions(game);
            char input = 'B';
            while (input != 'Q')
            {
                input = Console.ReadLine().ToUpper().First();
                if(input == 'R')
                {
                    game = new Game();

                }
                if (input == 'A' && !game.IsStarted)
                {
                    Console.WriteLine("Enter player name:");
                    var name = Console.ReadLine();
                    game.AddPlayer(name);
                    Console.WriteLine(game.Players.Count + " players ready!");
                    if (game.Players.Count >= 2 && game.Players.Count <= 4)
                    {
                        Console.WriteLine("Game can be started!");
                    }
                }
                if(input == 'S' && !game.IsStarted)
                {
                    game.StartGame();
                }
                if(input == 'N' && game.IsStarted)
                {
                    Console.WriteLine(game.NextMove());
                }
                if (input == 'K' && game.IsStarted)
                {
                    Console.Write("How many turns would you like to skip?");
                    string numberTurns = Console.ReadLine();
                    int turns;
                    bool isInteger = int.TryParse(numberTurns, out turns);
                    if(isInteger)
                    {
                        while(turns > 0)
                        {
                            Console.WriteLine(game.NextMove());
                            turns--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not an integer!");
                    }
                }
                if(input == 'C' && game.IsStarted)
                {
                    while(!game.Players.Any(x=>x.IsWinner))
                    {
                        Console.WriteLine(game.NextMove());
                    }
                }

                DisplayOptions(game);
            }
        }

        public static void DisplayOptions(Game game)
        {
            if(!game.IsStarted)
            {
                Console.WriteLine("A - Add Player");
                Console.WriteLine("S - Start Game");
            }
            else if(!game.Players.Any(x=>x.IsWinner))
            {
                Console.WriteLine("N - Next Turn");
                Console.WriteLine("K - Skip Turns");
                Console.WriteLine("C - Complete Game");
            }
            Console.WriteLine("R - Reset Game and Remove Players");
        }
    }
}
