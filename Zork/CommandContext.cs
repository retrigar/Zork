using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public struct CommandContext
    {
        public string CommandString { get; }
        public Command Command { get; }

        public CommandContext(string commandString, Command command)
        {
            CommandString = commandString;
            Command = command;
        }
    }
}
