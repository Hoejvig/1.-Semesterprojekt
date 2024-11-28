class SpaceBoss : Space
{
    private Item _item;
    private int _healthPoints;
    private String[] _questions;
    private String[] _answers;
    public bool Solved;
    
    public SpaceBoss(String name, Item item, int healthPoints, String[] questions, String[] answers) : base(name)
    {
        _item = item;
        _healthPoints = healthPoints;
        _questions = questions;
        _answers = answers;
    }
    
    public override void Welcome () {
        Console.WriteLine("You are now at "+name);
        Console.WriteLine("This room is a boss fight, you need to complete a series of questions to complete this room.");
        /* if (_healthPoints > 0 && Solved == false)
        {
            // Give random question (3 times)
            Console.WriteLine("Use 'solve <answer>' to solve the question");
            // Check if answer is correct, if correct then stop the battle.
        } */
        HashSet<string> exits = edges.Keys.ToHashSet();
        Console.WriteLine("Current exits are:");
        foreach (String exit in exits) {
            Console.WriteLine(" - "+exit);
        }
    }

    public override void Goodbye ()
    {
        Game.inventory.AddItem(_item);
        Solved = true;
    }
}