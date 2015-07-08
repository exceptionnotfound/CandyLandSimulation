using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Lib.Models
{
    public class Board
    {
        public List<BoardSpace> Spaces { get; set; }

        public Board()
        {
            Spaces = new List<BoardSpace>();

            //Add the standard colors
            for(int i = 1; i<= 21; i++)
            {
                Spaces.Add(new BoardSpace() { Color = CandyColor.Red });
                Spaces.Add(new BoardSpace() { Color = CandyColor.Purple });
                Spaces.Add(new BoardSpace() { Color = CandyColor.Yellow });
                Spaces.Add(new BoardSpace() { Color = CandyColor.Blue });
                Spaces.Add(new BoardSpace() { Color = CandyColor.Orange });
                Spaces.Add(new BoardSpace() { Color = CandyColor.Green });
            }
            
            //Add the speciality spaces
            Spaces.Insert(8, new BoardSpace() { Color = CandyColor.Cupcake });
            Spaces.Insert(19, new BoardSpace() { Color = CandyColor.IceCream });
            Spaces.Insert(41, new BoardSpace() { Color = CandyColor.Star });
            Spaces.Insert(68, new BoardSpace() { Color = CandyColor.Gingerbread });
            Spaces.Insert(91, new BoardSpace() { Color = CandyColor.Lollipop });
            Spaces.Insert(101, new BoardSpace() { Color = CandyColor.IcePop });
            Spaces.Insert(116, new BoardSpace() { Color = CandyColor.Chocolate });
            Spaces.Insert(132, new BoardSpace() { Color = CandyColor.Rainbow });

            //Replace the Licorice spaces
            Spaces.RemoveAt(44);
            Spaces.Insert(44, new BoardSpace() { Color = CandyColor.Green, IsLicorice = true });

            Spaces.RemoveAt(75);
            Spaces.Insert(75, new BoardSpace() { Color = CandyColor.Green, IsLicorice = true });

            //Replace the Shortcut spaces
            Spaces.RemoveAt(3);
            Spaces.Insert(3, new BoardSpace() { Color = CandyColor.Blue, ShortcutDestination = 59 });

            Spaces.RemoveAt(28);
            Spaces.Insert(28, new BoardSpace() { Color = CandyColor.Yellow, ShortcutDestination = 40 });

            int location = 0;
            foreach(var space in Spaces)
            {
                space.Location = location;
                location++;
            }
        }
    }
}
