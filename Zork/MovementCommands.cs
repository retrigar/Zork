using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public static class MovementCommands
    {
        public static void North(Game game, CommandContext commandContext) => Move(game, Directions.North);
        public static void South(Game game, CommandContext commandContext) => Move(game, Directions.South);
        public static void East(Game game, CommandContext commandContext) => Move(game, Directions.East);
        public static void West(Game game, CommandContext commandContext) => Move(game, Directions.West);

        private static void Move(Game game, Directions direction)
        {
            bool playerMoved = game.Player.Move(direction);
            if (playerMoved == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }
    }
}
