using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Core.Helper
{
    public static class CommandHelper
    {
        public static Plateau GetPlateauFromCommandText(string command)
        {
            int[] plateuaPosition = command.Trim().Split(' ').Select(command => Convert.ToInt32(command)).ToArray();
            return new Plateau(plateuaPosition[0],plateuaPosition[1]);
        }
        public static Position GetRoverPositionFromCommandText(string command)
        {
            string[] plateuaPosition = command.Trim().Split(' ');
            Coordinate coordinate = new Coordinate(int.Parse(plateuaPosition[0]), int.Parse(plateuaPosition[1]));
            Enum.TryParse(plateuaPosition[2], out Direction direction);
            return new Position(coordinate,direction);
        }
        public static string GetRoverCommandsFromCommandText(string command)
        {
            return command.Trim();
        }
    }
}
