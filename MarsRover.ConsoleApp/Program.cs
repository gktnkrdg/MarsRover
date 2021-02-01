using MarsRover.Application;
using Serilog;
using Serilog.Events;
using System;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                .CreateLogger();    

            try
            {
                var commandText = @"5 5
                                    1 2 N
                                    LMLMLMLMM
                                    3 3 E
                                    MMRMMRMRRM";
                CommandHandlerService s = new CommandHandlerService();

                s.ParseCommands(commandText.Split(Environment.NewLine));


            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
