using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Lib.Models
{
    public class BoardSpace
    {
        public CandyColor Color { get; set; }
        public bool IsLicorice { get; set; }
        public int? ShortcutDestination { get; set; }
        public int Location { get; set; }
    }
}
