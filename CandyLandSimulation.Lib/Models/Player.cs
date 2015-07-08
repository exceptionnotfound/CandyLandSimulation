using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyLandSimulation.Lib.Extensions;

namespace CandyLandSimulation.Lib.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int CurrentLocation { get; set; }
        public int Order { get; set; }
        public bool IsSkipped { get; set; }
        public bool IsWinner { get; set; }

        public void TakeTurn(Board board, CardDeck deck)
        {
            if(IsSkipped)
            {
                IsSkipped = false;
                return;
            }
            var card = deck.Draw();
            int matchingIndex = CurrentLocation;
            var space = board.Spaces.GetMatchingSpace(CurrentLocation, card);
            CurrentLocation = space.Location;
            if(space.IsLicorice)
            {
                IsSkipped = true;
            }
            if(space.ShortcutDestination.HasValue)
            {
                CurrentLocation = space.ShortcutDestination.Value;
            }
            if(CurrentLocation == 133)
            {
                IsWinner = true;
            }
        }
    }
}
