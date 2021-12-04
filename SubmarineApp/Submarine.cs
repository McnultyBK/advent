using SubmarineApp.SubmarineCommands;
using SubmarineApp.UserCommands;

namespace SubmarineApp
{
    public class Submarine
    {
        private readonly List<ISubmarineCommand> commands;
        private readonly IUserCommandParser commandParser;

        public int Depth { get; private set; }

        public int HorizontalPosition { get; private set; }

        public void AdjustDepth(int adjustment)
        {
            Depth += adjustment;
        }

        public void AdjustHorizontalPosition(int adjustment)
        {
            HorizontalPosition += adjustment;
        }

        public Submarine(List<ISubmarineCommand> commands, IUserCommandParser commandParser)
        {
            this.commands = commands;
            this.commandParser = commandParser;
        }

        public void AcceptCommand(string command)
        {
            var userCommand = commandParser.ParseUserCommand(command);
            commands.First(x => x.HandlesDirection(userCommand.Direction)).Execute(this, userCommand.Distance);
        }
    }
}
