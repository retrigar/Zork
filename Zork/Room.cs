using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public class Room
    {
        public string Name { get; }
        public string Description { get; set; }

        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;
    }
}
