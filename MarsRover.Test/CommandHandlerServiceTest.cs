using MarsRover.Application;
using MarsRover.Core;
using System;
using Xunit;

namespace MarsRover.Test
{
    public class CommandHandlerServiceTest
    {
       


        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM" }, "1 3 N")]
        [InlineData(new string[] { "5 5", "3 3 E", "MMRMMRMRRM" }, "5 1 E")]
        public void CommandHandler_GivenCommandParameters_ReturnCorrectRoverPosition(string[] input,string expectedRoverPosition)
        {
            Application.CommandHandlerService commandHandlerService = new Application.CommandHandlerService();

            Rover rover =  commandHandlerService.ParseCommands(input);

            Assert.Equal(rover.GetRoverPositionDetailedString(), expectedRoverPosition);
        }


    }
}
