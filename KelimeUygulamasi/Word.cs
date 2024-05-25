namespace KelimeUygulamasi
{
    public class Word
    {
        public string Turkish { get; set; }
        public string English { get; set; }

        public Word(string turkish, string english)
        {
            Turkish = turkish;
            English = english;
        }
    }
}
