using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Response
    {
        public string MessageName { get; set; }
        public List<bool> CommandsCompleted { get; set; } = new List<bool> { };

        public Response(){}


    }
}
