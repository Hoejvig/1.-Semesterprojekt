public class Player
{
    public string Name;
    public int HealthPoints = 100;
    public Inventory Inventory;

    public Player(string name)
    {
        Name = name;
        Inventory = new Inventory();
    }
}