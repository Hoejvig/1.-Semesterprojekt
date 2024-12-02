class SpaceBoss : Space
{
    private Item _item;
    private int _healthPoints;
    private String[] _questions;
    private String[] _answers;
    private bool _solved;
    
    public SpaceBoss(String name, Item item, int healthPoints, String[] questions, String[] answers) : base(name)
    {
        _item = item;
        _healthPoints = healthPoints;
        _questions = questions;
        _answers = answers;
        _solved = false;
    }
    
    public override void Welcome () {
        Console.WriteLine("");
        Console.WriteLine("This room is a boss fight, you need to complete a series of questions to complete this room.");
        
        if (_healthPoints > 0 && !_solved)
        {
            StartBattle();
        }
        
        HashSet<string> exits = edges.Keys.ToHashSet();
        Console.WriteLine("Current exits are:");
        foreach (String exit in exits) {
            Console.WriteLine(" - "+exit);
        }
    }
    
    private void StartBattle()
    {
        while (_healthPoints > 0 && Player.HealthPoints > 0)
        {
            for (int i = 0; i < _questions.Length; i++)
            {
                if (_healthPoints <= 0 || Player.HealthPoints <= 0) break;

                string question = _questions[i];
                string correctAnswer = _answers[i];

                Console.WriteLine($"Question: {question}");
                Console.WriteLine("Your answer: ");
                string playerAnswer = Console.ReadLine();

                // Make the input & answer lower case.
                // Trim: Removes all leading and trailing white-space characters from the current string.
                if (playerAnswer.Trim().ToLower() == correctAnswer.Trim().ToLower())
                {
                    Console.WriteLine("Correct! The boss loses 25 HP.");
                    _healthPoints -= 25;
                    Console.WriteLine($"Current HP: {_healthPoints}");
                }
                else
                {
                    Console.WriteLine("Incorrect! You lose 25 HP.");
                    Player.HealthPoints -= 25;
                    Console.WriteLine($"Current HP: {Player.HealthPoints}");
                }

                // Check if either the player or the boss has died
                if (_healthPoints <= 0)
                {
                    Console.WriteLine("The boss has been defeated!");
                    break;
                }
                else if (Player.HealthPoints <= 0)
                {
                    Console.WriteLine("You have been defeated!");
                    break;
                }
            }

            // End battle if one of the participants has no health left
            if (_healthPoints <= 0 || Player.HealthPoints <= 0)
            {
                break;
            }
        }

        // When battle is over
        Goodbye(); // Award item to player
    }

    public override void Goodbye ()
    {
        if (_healthPoints <= 0)
        {
            Game.inventory.AddItem(_item);
            _solved = true;
            Console.WriteLine("You've defeated the boss and gained an item! Use the command 'inventory' to check which.");
        }
        else
        {
            Console.WriteLine("Unlucky!! You didn't win!");
        }
    }
}