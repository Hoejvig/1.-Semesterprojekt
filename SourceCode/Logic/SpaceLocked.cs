class SpaceLocked : Space
{
    private String _requiredItemName;
    private Node _edge;
    
    public SpaceLocked (String name, String requiredItemName, Node edge) : base(name)
    {
        _requiredItemName = requiredItemName;
        _edge = edge;
    }
  
    public override void Welcome ()
    {
        Console.WriteLine("");
        // Check if any item in the inventory matches the required item name
        // Since Items is a List we can use IEnumerable methods.
        bool hasRequiredItem = Game.inventory.Items.Any(item => item.ItemName == _requiredItemName);

        if (hasRequiredItem)
        {
            Console.WriteLine("You are now at " + Name);
            try
            {
                this.AddEdge("Next_door", _edge);
            }
            catch (System.ArgumentException)
            {

            }
        }
        else
        {
            Console.WriteLine($"This is a locked room and you need '{_requiredItemName}' to proceed.");
            Console.WriteLine($"You don't have the item '{_requiredItemName}'");
        }
        
        HashSet<string> exits = edges.Keys.ToHashSet();
    
        Console.WriteLine("Current exits are:");
        foreach (String exit in exits) {
            Console.WriteLine(" - "+exit);
        }
    }
}