/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Follow an exit";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("I don't seem to know where that is. Correct usage: go <space>");
      return;
    }
    
    // var - fordi rummet kan være 4 datatyper
    var currentSpace = context.GetCurrent();

    // Vi tester om currentspace er datatypen SpaceQuestion
    if (currentSpace is SpaceQuestion spaceQuestion)
    {
      if (spaceQuestion.Solved == true)
      {
        // Try catch som fixer at programmet crasher hvis man prøver at gå ind i et rum som ikke eksistere.
        try
        {
          context.Transition(parameters[0]);
        }
        catch (System.Collections.Generic.KeyNotFoundException)
        {
          Console.WriteLine("That doesn't seem right. Try again.");
        }
      }
      else
      {
        Console.WriteLine("You haven't solved the question yet!");
      }
    }
    else
    {
      // Try catch som fixer at programmet crasher hvis man prøver at gå ind i et rum som ikke eksistere.
      try
      {
        context.Transition(parameters[0]);
      }
      catch (System.Collections.Generic.KeyNotFoundException)
      {
        Console.WriteLine("That doesn't seem right. Try again.");
      }
    }
  }
}
