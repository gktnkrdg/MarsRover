using MarsRover.Core;
using MarsRover.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MarsRover.Test
{
    public class RoverTest
    {
        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N","M" }, "1 3 N")]
        [InlineData(new string[] { "5 5", "3 3 E","L" }, "3 3 N")]
        public void  MoveRover_GivenSingleCommand_ReturnCorrectPosition(string[] input, string expectedRoverPosition)
        {
            var plateau = CommandHelper.GetPlateauFromCommandText(input[0]);
            var roverPosition = CommandHelper.GetRoverPositionFromCommandText(input[1]);
            var roverCommands = CommandHelper.GetRoverCommandsFromCommandText(input[2]);
            Rover rover = new Rover(plateau, roverPosition);

            rover.ExecuteCommands(roverCommands);

            Assert.Equal(rover.GetRoverPositionDetailedString(), expectedRoverPosition);
        }
    }
}
