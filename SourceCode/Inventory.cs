namespace WorldOfMath;

public class Inventory
{
    private Item[] items;
    public Inventory (Item[] items) {
        this.items = items;
    }
    public Inventory () : this(new Item[0]) {
    }
    
    public void ShowInventory () 
    {
        Console.WriteLine("Inventory:");
        foreach (Item item in items) 
        {
            Console.WriteLine(" - " + item);
        }
    }
}