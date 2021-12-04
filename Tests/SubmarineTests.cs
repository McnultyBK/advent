using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SubmarineApp.SubmarineCommands;
using SubmarineApp;
using SubmarineApp.UserCommands;

namespace Tests
{
    [TestClass]
    public class SubmarineTests
    {
        private readonly Submarine submarine;

        public SubmarineTests()
        {
            var commands = new List<ISubmarineCommand>
            {
                new ForwardCommand(),
                new BackwardsCommand(),
                new UpCommand(),
                new DownCommand()
            };
            submarine = new Submarine(commands, new UserCommandParser());
        }

        [TestMethod]
        public void TestSubmarine()
        {
            submarine.AcceptCommand("forward 5");
            submarine.AcceptCommand("down 5");
            submarine.AcceptCommand("forward 8");
            submarine.AcceptCommand("up 3");
            submarine.AcceptCommand("down 8");
            submarine.AcceptCommand("forward 2");

            Assert.AreEqual(150, submarine.HorizontalPosition * submarine.Depth);

        }
    }
}
