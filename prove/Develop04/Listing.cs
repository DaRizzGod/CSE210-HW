class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };

    public ListingActivity() : base("Listing", "This Activity will help you visualize about your life as you do the actvities in your life.") { }

    public override void Run()
    {
        base.Run();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        DisplaySpinner(3);

        Console.WriteLine("Start listing items. . .");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                count++;
            }
        }
        Console.WriteLine($"You listed {count} items.");
        End();
    }




}