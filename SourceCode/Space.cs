/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node
{
  private string question;
  public string answer;
  public bool solved;
  
  public Space (String name, String question = "", String answer = "") : base(name)
  {
    this.question = question;
    this.answer = answer;
    if (question == "")
    {
      solved = true;
    }
  }
  
  public void Welcome () {
    Console.WriteLine("You are now at "+name);
    if (question != "" && solved == false)
    {
      Console.WriteLine("There's a math question in here!");
      Console.WriteLine("{0}", question);
      Console.WriteLine("Use 'solve <answer>' when you think you got it");
    }
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine("Current exits are:");
    foreach (String exit in exits) {
      Console.WriteLine(" - "+exit);
    }
  }
  
  public void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
