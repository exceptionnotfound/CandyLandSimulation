using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Lib.Models
{
    public class Card
    {
        public CandyColor Color { get; set; }
        public int Amount { get; set; }

        public bool IsStandard()
        {
            return Color == CandyColor.Red
                || Color == CandyColor.Orange
                || Color == CandyColor.Yellow
                || Color == CandyColor.Green
                || Color == CandyColor.Blue
                || Color == CandyColor.Purple;
        }

        public bool IsSpecialty()
        {
            return Color == CandyColor.Cupcake
                || Color == CandyColor.IcePop
                || Color == CandyColor.Chocolate
                || Color == CandyColor.IceCream
                || Color == CandyColor.Gingerbread
                || Color == CandyColor.Star
                || Color == CandyColor.Lollipop;
        }
    }
}
