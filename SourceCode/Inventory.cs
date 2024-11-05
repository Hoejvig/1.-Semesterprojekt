namespace WorldOfMath;

public class Inventory
{

    
    // Array for storing badges
    public Item[] items = new Item[5];
    
    // Method to show inventory

    public void ShowInventory () 
    {
        Console.WriteLine("Inventory:");
        foreach (Item item in items) 
        {
            Console.WriteLine(" - " + item);
        }
    }
    
    // Attribute to see where to add badges in array index
    int NextOpenIndex = 0;
    
    
    // Method to add badges after boss fight
   public void AddItem(Item Item)
    {
        if (NextOpenIndex < items.Length)
        {
            items[NextOpenIndex] = Badge; 
        }
        NextOpenIndex++;
    }
}
