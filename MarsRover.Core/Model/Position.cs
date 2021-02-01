using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core
{
    public class Position
    {
        public Coordinate Coordinate { get;  set; }
        public Direction Direction { get;  set; }

        public Position(Coordinate coordinate, Direction direction)
        {
            Coordinate = coordinate;
            Direction = direction;
        }
       
    }
}
