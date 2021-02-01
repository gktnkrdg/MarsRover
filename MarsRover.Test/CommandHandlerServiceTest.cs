using MarsRover.Application;
using MarsRover.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MarsRover.Test
{
    public class CommandHandlerServiceTest
    {
        [Fact]
        public void CommandHandler_GivenWrongPleateuCommands_ReturnInvalidOperationException()
        {
            CommandHandlerService commandHandlerService = new CommandHandlerService();
            var input = new string[] { "5 5", "5 5 N", "MM" };

            Action act = () => commandHandlerService.ParseCommands(input);

            Assert.Throws<InvalidOperationException>(act);

        }



        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM" }, "1 3 N")]
        [InlineData(new string[] { "5 5", "3 3 E", "MMRMMRMRRM" }, "5 1 E")]
        public void CommandHandler_GivenCommands_ReturnCorrectRoverPosition(string[] input,string expectedRoverPosition)
        {
            CommandHandlerService commandHandlerService = new CommandHandlerService();

            List<Rover> rovers =  commandHandlerService.ParseCommands(input);

            Assert.Equal(rovers.First().GetRoverPositionDetailedString(), expectedRoverPosition);
        }


        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM" ,"3 3 E", "MMRMMRMRRM"}, new string[] { "1 3 N", "5 1 E" })]
        public void CommandHandler_GivenCommandParameters_ReturnCorrectRoverPositions(string[] input, string[] expectedRoverPositions)
        {
            Application.CommandHandlerService commandHandlerService = new CommandHandlerService();

            List<Rover> rovers = commandHandlerService.ParseCommands(input);

            
            Assert.Equal(rovers.Select( c=> c.GetRoverPositionDetailedString()).ToArray(), expectedRoverPositions);
        }
    }
}
