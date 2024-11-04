/* Command for transitioning between spaces
 */

class CommandSolve : BaseCommand, ICommand
{
    private string answer;
    public CommandSolve () {
        description = "Used to solve a math question";
    }
  
    public void Execute (Context context, string command, string[] parameters) {
        if (GuardEq(parameters, 1)) {
            Console.WriteLine("Correct usage: solve <answer>");
            return;
        }
        
        if (parameters[0] == context.GetCurrent().answer)
        {
            Console.WriteLine("Correct move on!");
            context.GetCurrent().solved = true;
        }
        else
        {
            Console.WriteLine("That doesn't seem right.");
        }
    }
}