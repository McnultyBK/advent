namespace SubmarineApp.UserCommands
{
    public class UserCommand
    {
        public string Direction { get; }
        public int Distance { get; }

        public UserCommand(string direction, int distance)
        {
            Direction = direction;
            Distance = distance;
        }
    }
}
