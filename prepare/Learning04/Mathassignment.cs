public class Mathassignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public Mathassignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName,topic)

        {
             _textbookSection = textbookSection;
             _problems = problems; 
        }

        public string Gethomeowrklist()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
}


