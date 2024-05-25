using System.Collections.Generic;
using System.Linq;

namespace KelimeUygulamasi
{
    public static class Database
    {
        private static List<User> users = new List<User>();
        private static List<Word> words = new List<Word>();
        private static List<Word> learnedWords = new List<Word>(); // Öğrenilmiş kelimeler

        static Database()
        {
            // Örnek kullanıcılar ekleyelim
            users.Add(new User("testuser", "password123"));
        }

        public static User FindUser(string username)
        {
            return users.Find(u => u.Username == username);
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static void AddWord(Word word)
        {
            words.Add(word);
        }

        public static List<Word> GetWords()
        {
            return words;
        }

        public static void AddLearnedWord(Word word)
        {
            if (!learnedWords.Contains(word))
            {
                learnedWords.Add(word);
            }
        }

        public static List<Word> GetLearnedWords()
        {
            return learnedWords;
        }
    }
}
