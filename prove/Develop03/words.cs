

    public class Words
    {
        private string _text;
        private bool _hidden;

        public Words(string text)
        {
            _text = text;
            _hidden= false;
        }

        public void HideWord()

        {
            _hidden= true;
        }

        public string GetText()
        {
            if(_hidden)
            {
                return "______";
            }
            else 
            {
                return _text;
            }
        }

        public bool IsHidden()
        {
            return _hidden;
        }
    }