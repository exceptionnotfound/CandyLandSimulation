using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLandSimulation.Lib.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int CurrentLocation { get; set; }
        public CandyColor TokenColor { get; set; }
        public int Order { get; set; }
    }
}
