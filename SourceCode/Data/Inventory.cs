public class Inventory
{
    // Initialize a list of items.
    public List<Item> Items = new();

    public void AddItem(Item item)
    {
        Items.Add(item);
    }
    
    public void ShowInventory () 
    {
        Console.WriteLine("Inventory:");
        foreach (Item item in Items) 
        {
            Console.WriteLine(" - " + item.ItemName);
        }
    }
}
