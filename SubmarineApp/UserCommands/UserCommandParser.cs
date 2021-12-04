namespace SubmarineApp.UserCommands
{
    public class UserCommandParser : IUserCommandParser
    {
        public UserCommand ParseUserCommand(string userCommand)
        {
            var steps = 0;
            var input = userCommand.Split(" ");
            if (input?.Length > 0)
            {
                if (int.TryParse(input[1], out steps))
                {
                    return new UserCommand(input[0], steps);
                }
            }
            throw new ArgumentException("Invalid user input provided");
        }
    }
}
