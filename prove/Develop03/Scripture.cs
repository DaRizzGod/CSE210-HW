public class Scripture
    {
        private List<Words> _verse;
        private Reference _reference; 

        public Scripture(Reference reference,string text)
        {
            _reference = reference;
            string[] words=text.Split(" ");
            _verse=new List<Words>();
            foreach(string word in words)
            {
                _verse.Add(new Words(word));
            }
        }

        public string GetVerse()
        {
            string verseText="";
            foreach(Words word in _verse)
            {
                verseText += word.GetText() + " ";
            }
            return verseText.Trim();
        }

        public void hiderandomword()
        {
            Random rand = new Random();
            List<Words> visibleWords = _verse.Where(word => !word.IsHidden()).ToList();

            if (visibleWords.Count > 0)
            {
                Words wordToHide = visibleWords[rand.Next(visibleWords.Count)];
                wordToHide.HideWord();
            }
        }
        public bool AllWordsHidden()
        {
            return _verse.All(word => word.IsHidden());
        }
        public string GetFullScripture()
        {
            return $"{_reference.GetReferences()} {GetVerse()}";
        }
        
    }




