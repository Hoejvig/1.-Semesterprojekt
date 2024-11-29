/* Context class to hold all context relevant to a session.
 */

class Context {
  private Space _current;
  private bool _done = false;
  
  public Context (Space node) {
    _current = node;
  }
  
  public Space GetCurrent() {
    return _current;
  }
  
  public void Transition (string direction) {
    Space next = _current.FollowEdge(direction);
    if (next==null) {
      Console.WriteLine("You are confused, and walk in a circle looking for '"+direction+"'. In the end you give up 😩");
    } else {
      _current.Goodbye();
      _current = next;
      _current.Welcome();
    }
  }
  
  public void MakeDone () {
    _done = true;
  }
  
  public bool IsDone () {
    return _done;
  }
}

