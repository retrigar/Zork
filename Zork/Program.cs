using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.LOOK:
                        command = Commands.LOOK;
                        outputString = "this is an open field west of a white house, with a boarded front door. A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                        command = Commands.NORTH;
                        outputString = "You moved north.";
                        break;

                    case Commands.SOUTH:
                        command = Commands.SOUTH;
                        outputString = "You moved south.";
                        break;

                    case Commands.EAST:
                        command = Commands.EAST;
                        outputString = "You moved east.";
                        break;

                    case Commands.WEST:
                        command = Commands.WEST;
                        outputString = "You moved west.";
                        break;

                    case Commands.QUIT:
                        command = Commands.QUIT;
                        outputString = "Thank you for playing!";
                        break;

                    default:
                        command = Commands.UNKNOWN;
                        outputString = "Unknown command.";
                        break;
                };

                //return command;
                //return outputString;
                Console.WriteLine(outputString);
            }           
        }


        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);            
    }
}
