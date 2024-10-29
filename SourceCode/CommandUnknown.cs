/* Fallback for when a command is not implemented
 */

class CommandUnknown : BaseCommand, ICommand {
  public void Execute (Context context, string command, string[] parameters) {
    Console.WriteLine("Woopsie, I don't understand '"+command+"' 😕");
  }
}
