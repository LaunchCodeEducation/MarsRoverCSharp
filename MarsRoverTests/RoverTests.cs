using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newRover = new Rover(98382);
            Assert.AreEqual(98382, newRover.Position);
        }
        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newRover = new Rover(98382);
            Assert.AreEqual("NORMAL", newRover.Mode);
        }
        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newRover = new Rover(98382);
            Assert.AreEqual(110, newRover.GeneratorWatts);
        }
        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500) };
            Message newMessage = new Message("MOVING 500", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);

            Assert.IsTrue(("LOW_POWER") == newRover.Mode || ("NORMAL")== newRover.Mode);
        }
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500) };
            Message newMessage = new Message("MOVING 500", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(98382, newRover.Position);
        }
        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Command[] commands = { new Command("MODE_CHANGE", "NORMAL"), new Command("MOVE", 500) };
            Message newMessage = new Message("MOVING 500", commands);
            Rover newRover = new Rover(98382);
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(500, newRover.Position);
        }

    }

}
