/* Command for exiting program
 */

class CommandExit : BaseCommand, ICommand {
  public void Execute (Context context, string command, string[] parameters) {
    context.MakeDone();
  }
}
