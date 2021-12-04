namespace SubmarineApp.UserCommands
{
    public interface IUserCommandParser
    {
        UserCommand ParseUserCommand(string userCommand);
    }
}