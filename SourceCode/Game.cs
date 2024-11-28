/* Main class for launching the game
 */

class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);

  public static Inventory inventory = new Inventory();
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("solve", new CommandSolve());
    registry.Register("inventory", new CommandInventory());
  }
  
  static void Main (string[] args) {
    Console.WriteLine("Welcome to World of Math!");
    Console.WriteLine("A fantastic game about learning mathematics through a interactive game.");
    Console.WriteLine("");
    Console.WriteLine("Use 'go' to move between rooms.");
    Console.WriteLine("Use 'help' for a list of commands.");
    Console.WriteLine("");
    inventory.AddItem(new Item("Addition Emblem"));
    
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
