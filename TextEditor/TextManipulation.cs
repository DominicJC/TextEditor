using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    static class TextManipulation
    {
        public static int CountWords(string input)
        {
            input.Trim();

            string[] wordArray = input.Split(new char[] {' ', '.', '?', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            return wordArray.Length;
        }

        public static string GetMostFrequentWord(string input)
        {
            if (input.Length > 0)
            {
                string outputString = "";
                input = input.ToLower();
                Dictionary<string, int> wordList = new Dictionary<string, int>();
                var words = input
                    .Split()
                    .GroupBy(a => a)
                    .OrderByDescending(b => b.Count());

                foreach (var group in words)
                {
                    wordList.Add(group.Key, group.Count());
                }
                if (wordList.Count > 1)
                {
                    if (wordList.Values.ElementAt(0) == wordList.Values.ElementAt(1))
                    {
                        outputString = wordList.Keys.ElementAt(0) + ", ";

                        for (int i = 1; i < wordList.Count; i++)
                        {
                            if (wordList.Values.ElementAt(i) == wordList.Values.ElementAt(0))
                            {
                                outputString += wordList.Keys.ElementAt(i) + ", ";
                            }
                        }
                    }
                    else
                    {
                        outputString = wordList.Keys.ElementAt(0);
                    }
                }
                else
                {
                    outputString = wordList.Keys.ElementAt(0);
                }
                return outputString;
            }
            return "No words";
        }

        public static string getLongestSentence(string input)
        {
            List<string> sentences = new List<string>();
            var words = input
                .Split(new char[] { '.' })
                .OrderByDescending(b => b.Count());

            foreach (var group in words)
            {
                sentences.Add(group);
            }

            return sentences[0];
        }

        public static string RemovePunctuationAndSpaces(string word)
        {
            StringBuilder compare = new StringBuilder();
            foreach (char c in word)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    compare.Append(c);
                }
            }

            return compare.ToString();
        }

        public static bool IsItAPalindrome(string word)
        {
            string compare = RemovePunctuationAndSpaces(word.ToLower());

            int x = 0;
            int y = compare.Length - 1;

            while (x < y)
            {
                if (compare[x] != compare[y])
                {
                    return false;
                }

                x++;
                y--;
            }

            return true;
        }

        public static bool AreStringsAnagrams(string a, string b)
        {
            a = a.Trim().ToLower();
            b = b.Trim().ToLower();
            
            if(a.Length != b.Length)
            {
                return false;
            }

            char[] subject = a.ToCharArray();
            Array.Sort(subject);
            string resultA = new string(subject);

            char[] anagram = b.ToCharArray();
            Array.Sort(anagram);
            string resultB = new string(anagram);


            if (resultA == resultB)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
