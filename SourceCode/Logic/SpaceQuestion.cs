class SpaceQuestion : Space
{
    private string _question;
    private string _answer;
    public bool Solved;
  
    public SpaceQuestion(String name, String question, String answer) : base(name)
    {
        _question = question;
        _answer = answer;
    }
  
    public override void Welcome ()
    {
        Console.WriteLine("");
        Console.WriteLine("You are now at "+Name);
        if (Solved == false)
        {
            Console.WriteLine("There's a math question in here!");
            Console.WriteLine($"{_question}");
            Console.WriteLine("Type your answer when you think you got it");
            string playerAnswer = Console.ReadLine();

            if (playerAnswer == _answer)
            {
                Solved = true;
                Console.WriteLine("Correct! Move on");
            }
            else
            {
                Console.WriteLine("That doesn't seem right");
            }
        }
        HashSet<string> exits = edges.Keys.ToHashSet();
        Console.WriteLine("Current exits are:");
        foreach (String exit in exits) {
            Console.WriteLine(" - "+exit);
        }
    }
}