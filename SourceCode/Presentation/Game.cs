/* Main class for launching the game
 */

class Game {
  private static World    world    = new World();
  private static Context  context  = new Context(world.GetEntry());
  private static ICommand fallback = new CommandUnknown();
  private static Registry registry = new Registry(context, fallback);

  public static Inventory inventory = new Inventory();
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("inv", new CommandInventory());
  }
  
  static void Main (string[] args) {
    Console.WriteLine("Welcome to World of Math!");
    Console.WriteLine("A fantastic game about learning mathematics through a interactive game.");
    Console.WriteLine("");
    Console.WriteLine("Use 'go' to move between rooms.");
    Console.WriteLine("Use 'help' for a list of commands.");
    Console.WriteLine("");

    InitRegistry();
    context.GetCurrent().Welcome();

    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Game Over 😥");
  }
}
