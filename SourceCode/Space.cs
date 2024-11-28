// Space class for modeling spaces (rooms, caves, ...)

class Space : Node
{
  private string _text;
  
  public Space (String name, String text = "") : base(name)
  {
    _text = text;
  }
  
  public virtual void Welcome () {
    Console.WriteLine("You are now at "+name);

    if (_text != null)
    {
      String[] parts = _text.Split('\\');
      foreach (String part in parts)
      {
        Console.WriteLine(part);
      }
    }
    
    HashSet<string> exits = edges.Keys.ToHashSet();
    
    Console.WriteLine("Current exits are:");
    foreach (String exit in exits) {
      Console.WriteLine(" - "+exit);
    }
  }
  
  public virtual void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
