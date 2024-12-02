class SpaceQuestion : Space
{
    private string _question;
    public string Answer;
    public bool Solved;
  
    public SpaceQuestion(String name, String question, String answer) : base(name)
    {
        _question = question;
        Answer = answer;
    }
  
    public override void Welcome () {
        Console.WriteLine("You are now at "+name);
        if (_question != "" && Solved == false)
        {
            Console.WriteLine("There's a math question in here!");
            Console.WriteLine($"{_question}");
            Console.WriteLine("Use 'solve <answer>' when you think you got it");
        }
        HashSet<string> exits = edges.Keys.ToHashSet();
        Console.WriteLine("Current exits are:");
        foreach (String exit in exits) {
            Console.WriteLine(" - "+exit);
        }
    }
}