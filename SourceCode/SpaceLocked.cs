namespace WorldOfMath;

class SpaceLocked : Space
{
    private Item _item;
    
    public SpaceLocked (String name, Item item) : base(name)
    {
        _item = item;
    }
  
    public override void Welcome () {
        Console.WriteLine("You are now at "+name);
        Console.WriteLine("This is a locked room and you need " + _item + " to proceed.");
        if (Game.inventory.Items.Contains(_item))
        {
            HashSet<string> exits = edges.Keys.ToHashSet();
    
            Console.WriteLine("Current exits are:");
            foreach (String exit in exits) {
                Console.WriteLine(" - "+exit);
            }
        }
        else
        {
            Console.WriteLine("You don't have " + _item);
            
        }
        
    }
}