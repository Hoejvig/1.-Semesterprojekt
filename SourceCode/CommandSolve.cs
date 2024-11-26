// Command for transitioning between spaces

class CommandSolve : BaseCommand, ICommand
{
    public CommandSolve () {
        description = "Used to solve a math question";
    }
  
    public void Execute(Context context, string command, string[] parameters) {
        if (GuardEq(parameters, 1)) {
            Console.WriteLine("Correct usage: solve <answer>");
            return;
        }

        // Retrieve the current space from the context
        var currentSpace = context.GetCurrent();

        // Check if the current space is a SpaceQuestion
        if (currentSpace is SpaceQuestion spaceQuestion) {
            // Compare the provided answer with the SpaceQuestion's answer
            if (parameters[0] == spaceQuestion.Answer) {
                Console.WriteLine("Correct, move on!");
                spaceQuestion.Solved = true;
            } else {
                Console.WriteLine("That doesn't seem right.");
            }
        } else {
            Console.WriteLine("There's no question to solve here.");
        }
    }

}