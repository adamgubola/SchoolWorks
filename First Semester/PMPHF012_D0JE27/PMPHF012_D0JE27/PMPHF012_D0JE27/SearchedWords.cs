using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PMPHF012_D0JE27
{
    internal class SearchedWords
    {
        string[] searchedWords;
        int count;
        public string[] getSearchedWords() { return searchedWords; }

        public SearchedWords(int words)
        {
            searchedWords = new string[words];
            count = 0;

        }
        public void AddWord(string word)
        {
            if (count < searchedWords.Length)
            {
                searchedWords[count] = word.ToLower();
                count++;
            }
            else
            {
                Console.WriteLine("Nincs több hely a szavak tárolására.");
            }
        }

        public void RemoveWord(string word)
        {
            for (int i = 0; i < searchedWords.Length; i++)
            {
                if (searchedWords[i].Equals(word) && word.Length>0)
                {
                    this.searchedWords[i] = "";
                }
            }
        }

       


        public void Write() {foreach (string word in searchedWords){ Console.WriteLine(word); } }
    }
}
