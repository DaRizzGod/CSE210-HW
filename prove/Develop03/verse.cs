public class Verse
    {
        private List<Word> _verse; 

        public Verse(string text)
        {
            string[] bullets=text.Split(" ");
            _verse=new List<Word>();
            foreach(string bullet in bullets)
            {
                Word bulletWord = new Word(bullet);
                _verse.Add(bulletWord);
            }
        }

        public string GetVerse()
        {
            string grace=("");
            foreach(Word item in _verse)
            {
                grace+= item.GetText();
                grace+=" ";
            }
            return grace;
        }
        // public void hidefirstword()
        // {
        //     _verse[0].HideWord();
        // }

        public void hiderandomword()
        {
            _verse[10].HideWord();
            _verse[20].HideWord();
            _verse[30].HideWord();
        }


         public Verse1(string text)
        {
            string[] bullets1=text.Split(" ");
            _verse=new List<Word>();
            foreach(string bullet in bullets1)
            {
                Word bulletWord = new Word(bullets1);
                _verse.Add(bulletWord);
            }
        }

        public string GetVerse1()
        {
            string grace=("");
            foreach(Word item in _verse)
            {
                grace+= item.GetText();
                grace+=" ";
            }
            return grace;
        }

        public void hiderandomword1()
        {
            _verse[1].HideWord();
            _verse[10].HideWord();
            _verse[5].HideWord();
        }
    }




