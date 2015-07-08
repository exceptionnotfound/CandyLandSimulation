using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Lib.Models
{
    public class Game
    {
        public Board Board { get; set; }

        public CardDeck Deck { get; set; }

        public List<Player> Players { get; set; }

        public int CurrentPlayer { get; set; }

        public bool IsStarted { get; set; }

        public Game()
        {
            Board = new Board();
            Deck = new CardDeck();
            Players = new List<Player>();
        }

        public void AddPlayer(string name)
        {
            if(!IsStarted && Players.Count < 4)
            {
                Players.Add(new Player() { Name = name});
            }
        }

        public void StartGame()
        {
            if(Players.Count >= 2 && Players.Count <= 4)
            {
                IsStarted = true;
            }
        }

        public string NextMove()
        {
            if(IsStarted)
            {
                var player = Players[CurrentPlayer];
                var message = player.TakeTurn(Board, Deck);
                CurrentPlayer++;
                if(CurrentPlayer > Players.Count - 1)
                {
                    CurrentPlayer = 0;
                }
                return message;
            }
            return "Game has not started yet!";
        }
    }
}
