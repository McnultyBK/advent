// See https://aka.ms/new-console-template for more information
using SubmarineApp;
using SubmarineApp.SubmarineCommands;
using SubmarineApp.UserCommands;

var commands = new List<ISubmarineCommand>
{
    new ForwardCommand(),
    new BackwardsCommand(),
    new UpCommand(),
    new DownCommand()
};

var submarine = new Submarine(commands, new UserCommandParser());

while (true)
{
    var a = Console.ReadLine();

    if (a is not null)
        submarine.AcceptCommand(a);
}


