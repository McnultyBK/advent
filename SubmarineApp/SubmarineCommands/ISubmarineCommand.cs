namespace SubmarineApp.SubmarineCommands
{
    public interface ISubmarineCommand
    {
        bool HandlesDirection(string input);
        void Execute(Submarine submarine, int steps);
    }
}