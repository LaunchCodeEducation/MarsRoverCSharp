using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Name required.", ex.Message);
            }
        }

        [TestMethod]
        public void ConstructorSetsCommandName()
        {
            Message newMessage = new Message("MOVE");
            Assert.AreEqual(newMessage.Name, "MOVE");
        }

        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500) };
            Message newMessage = new Message("MOVING 500",commands);
            
            Assert.AreEqual(newMessage.Commands,commands);
        }
    }
}
