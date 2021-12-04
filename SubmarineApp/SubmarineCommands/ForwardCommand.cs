using SubmarineApp;

namespace SubmarineApp.SubmarineCommands
{
    public class ForwardCommand : ISubmarineCommand
    {
        public void Execute(Submarine submarine, int distance)
        {
            submarine.AdjustHorizontalPosition(distance);
        }

        public bool HandlesDirection(string input)
        {
            return input.Equals("Forward", StringComparison.OrdinalIgnoreCase);
        }
    }
}
