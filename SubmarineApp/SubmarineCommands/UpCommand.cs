namespace SubmarineApp.SubmarineCommands
{
    public class UpCommand : ISubmarineCommand
    {
        public void Execute(Submarine submarine, int distance)
        {
            submarine.AdjustDepth(distance * -1);
        }

        public bool HandlesDirection(string input)
        {
            return input.Equals("Up", StringComparison.OrdinalIgnoreCase);
        }
    }
}
