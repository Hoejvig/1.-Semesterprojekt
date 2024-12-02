/* Command for exiting program
 */

class CommandExit : BaseCommand, ICommand {


    public CommandExit()
    {
        description = "Type exit to quit the game";
    }
        
    public void Execute (Context context, string command, string[] parameters) {
        context.MakeDone();
    }
}
