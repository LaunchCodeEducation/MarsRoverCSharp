using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public Rover(int position)
        {
        }

        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts; 
        }

        // UNCOMMENT when you reach the Rover tests //
        //public Response ReceiveMessage(Message message)
        //{
        //    Response newResponse;

        //    return newResponse;
        //}
    }
}
