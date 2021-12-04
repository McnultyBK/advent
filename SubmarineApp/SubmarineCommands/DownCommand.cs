namespace SubmarineApp.SubmarineCommands
{
    public class DownCommand : ISubmarineCommand
    {
        public void Execute(Submarine submarine, int distance)
        {
            submarine.AdjustDepth(distance);
        }

        public bool HandlesDirection(string input)
        {
            return input.Equals("Down", StringComparison.OrdinalIgnoreCase);
        }
    }
}
