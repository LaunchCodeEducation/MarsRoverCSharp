using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }
        public Message(string name)
        {
            Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Name required.");
            }
        }

        public Message(string name, Command[] commands )
        {
            Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Name required.");
            }
            Commands = commands;
        }
    }
}
