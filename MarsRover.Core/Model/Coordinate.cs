using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
       
    }
}
