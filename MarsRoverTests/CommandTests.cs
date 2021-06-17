using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System;

namespace MarsRoverTests
{
    [TestClass]
    public class CommandTests
    {

        [TestMethod]
        public void ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty()
        {
            try
            {
                new Command("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Command type required.", ex.Message);
            }
        }

        [TestMethod]
        public void ConstructorSetsCommandType()
        {
            Command newCommand = new Command("MOVE", 0);
            Assert.AreEqual(newCommand.CommandType, "MOVE");
        }

        [TestMethod]
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPostion, 20);
        }

        [TestMethod]
        public void ConstructorSetsInitialNewModeValue()
        {
            Command newCommand = new Command("MODE_CHANGE", "NORMAL");
            Assert.AreEqual(newCommand.NewMode, "NORMAL");
        }
    }
}
