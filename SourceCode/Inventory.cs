public class Inventory
{
    private Item[] _items;
    
    public void ShowInventory () 
    {
        Console.WriteLine("Inventory:");
        foreach (Item item in _items) 
        {
            Console.WriteLine(" - " + item);
        }
    }
}
