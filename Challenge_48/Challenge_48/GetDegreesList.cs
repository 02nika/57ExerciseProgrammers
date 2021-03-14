using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_48
{
    class GetDegreesList
    {
        public static List<Degrees> degrees = new List<Degrees>()
        {
            new Degrees(){ CardinalDirection="North",            Start=348.75, End=11.25},
            new Degrees(){ CardinalDirection="NorthNorthEast",   Start=11.25, End=33.75},
            new Degrees(){ CardinalDirection="NorthEast",        Start=33.75, End=56.25},
            new Degrees(){ CardinalDirection="EastNorthEast",    Start=56.25, End=78.75},
            new Degrees(){ CardinalDirection="East",             Start=78.75, End=101.25},
            new Degrees(){ CardinalDirection="EastSouthEast",    Start=101.25, End=123.75},
            new Degrees(){ CardinalDirection="SouthEast",        Start=123.75, End=146.25},
            new Degrees(){ CardinalDirection="SouthSouthEast",   Start=146.25, End=168.75},
            new Degrees(){ CardinalDirection="South",            Start=168.75, End=191.25},
            new Degrees(){ CardinalDirection="SouthSouthWest",   Start=191.25, End=213.75},
            new Degrees(){ CardinalDirection="SouthWest",        Start=213.75, End=236.25},
            new Degrees(){ CardinalDirection="WestSouthWest",    Start=236.25, End=258.75},
            new Degrees(){ CardinalDirection="West",             Start=258.75, End=281.25},
            new Degrees(){ CardinalDirection="WestNorthWest",    Start=281.25, End=303.75},
            new Degrees(){ CardinalDirection="NorthWest",        Start=303.75, End=326.25},
            new Degrees(){ CardinalDirection="NorthNorthWest",   Start=326.25, End=348.75},

        };
    }
}
