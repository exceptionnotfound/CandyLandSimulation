using CandyLandSimulation.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Lib.Extensions
{
    public static class Extensions
    {
        public static BoardSpace GetMatchingSpace(this List<BoardSpace> spaces, int currentIndex, Card card)
        {
            if(card.IsSpecialty()) //The speciality cards can move you forward or backward
            {
                var allMatches = spaces.Where(x => x.Color == card.Color);
                return allMatches.First();
            }
            else //The standard cards can only move you forward
            {
                var index = spaces.FindIndex(currentIndex + 1, x => x.Color == card.Color);
                if(index == -1)
                {
                    return new BoardSpace()
                    {
                        Color = CandyColor.Rainbow,
                        Location = 133
                    };
                }
                return spaces[index];
            }
        }
    }
}
