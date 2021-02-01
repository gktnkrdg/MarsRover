
using MarsRover.Core;
using MarsRover.Core.Helper;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MarsRover.Application
{
    public class CommandHandlerService
    {
        public Rover ParseCommands(string[] commandsText)
        {
            //validation

            //var commands = commandsText.Split(Environment.NewLine);


            var plateau = CommandHelper.GetPlateauFromCommandText(commandsText[0]);

            //List<Rover> rovers = new List<Rover>();
            //for (int i = 1; i < commandsText.Count(); i = i + 2)
            //{
                var roverPosition = CommandHelper.GetRoverPositionFromCommandText(commandsText[1]);

                var roverCommands = CommandHelper.GetRoverCommandsFromCommandText(commandsText[2]);

              

                Rover rover = new Rover(plateau, roverPosition);
                //rovers.Add(rover);
                rover.ExecuteCommands(roverCommands);
                Log.Information($@"{ rover.Position.Coordinate.X} { rover.Position.Coordinate.Y},{rover.Position.Direction.ToString()}");
            //}
            return rover;
            
        }
    }
}