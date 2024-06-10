

    public class Word
    {
        private string _text;
        private bool _hidden;

        public Word(string text)
        {
            _text = text;
            _hidden= true;
        }

        public void HideWord()

        {
            _hidden= false;
        }

        public string GetText()
        {
            if(_hidden)
            {
                return _text;
            }
            else 
            {
                return "_____";
            }
        }
    }