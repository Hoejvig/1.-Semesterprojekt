// Node class for modeling graphs

class Node {
  protected string Name;
  protected Dictionary<string, Node> edges = new Dictionary<string, Node>();
  
  public Node (string name) {
    this.Name = name;
  }
  
  public String GetName () {
    return Name;
  }
  
  public void AddEdge (string name, Node node) {
    edges.Add(name, node);
  }
  
  public virtual Node FollowEdge (string direction) {
    return edges[direction];
  }
}

