namespace SubmarineApp.SubmarineCommands
{
    public class BackwardsCommand : ISubmarineCommand
    {
        public void Execute(Submarine submarine, int distance)
        {
            submarine.AdjustHorizontalPosition(distance * -1);
        }

        public bool HandlesDirection(string input)
        {
            return input.Equals("Backward", StringComparison.OrdinalIgnoreCase);
        }
    }
}
