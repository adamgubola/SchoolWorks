using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PMPHF011_D0JE27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numsOfwordsToSearch=int.Parse(Console.ReadLine());
            String[] wordsToSearch = new String[numsOfwordsToSearch];
            String[] wordsToSearchReverse = new String[numsOfwordsToSearch];
            String secretMessage = "";
            String numsOfLetters = "";
            bool isOneMatch = false;

            for (int i = 0; i < numsOfwordsToSearch; i++)
            {
                wordsToSearch[i] = Console.ReadLine();
            }

            String[] textArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < wordsToSearch.Length; i++)
            {
                wordsToSearchReverse[i] = "";

                for (int j = wordsToSearch[i].Length-1; j >= 0; j--)
                {
                    wordsToSearchReverse[i] += wordsToSearch[i][j];

                }
            }


            for (int i = 0; i < textArray.Length; i++)
            {

                for (int j = 0; j < wordsToSearch.Length; j++)
                {
                    if (textArray[i].Contains(wordsToSearch[j]))
                    {
                        int currentIndex = textArray[i].IndexOf(wordsToSearch[j]);
                        int currentWordLength = wordsToSearch[j].Length;

                        for (int k = 0; k < currentWordLength; k++)
                        {
                            if (string.IsNullOrEmpty(numsOfLetters))
                            {
                                numsOfLetters += currentIndex.ToString();
                                isOneMatch = true;
                            }
                            else
                            {
                                numsOfLetters += "," + (currentIndex + k).ToString();
                                isOneMatch = true ;
                            }

                        }
                    }
                    else
                    {
                        isOneMatch = false;

                    }

                    int nextCurrentWordLength = wordsToSearch[j].Length;
                    int nextMatchCurrentIndex = textArray[i].IndexOf(wordsToSearch[j]) + nextCurrentWordLength;
                    int nextMatchCounter= nextCurrentWordLength;
                    while (isOneMatch)
                    {

                        for (int r = nextMatchCurrentIndex; r <= textArray[i].Length; r += nextMatchCounter)
                        {
                            String pieceTeaxtArray = textArray[i].Substring(r);

                            if (pieceTeaxtArray.Contains(wordsToSearchReverse[j]))
                            {

                                int currentIndex = pieceTeaxtArray.IndexOf(wordsToSearchReverse[j]);
                                int currentWordLength = wordsToSearchReverse[j].Length;

                                for (int k = 0; k < currentWordLength; k++)
                                {
                                    if (string.IsNullOrEmpty(numsOfLetters))
                                    {
                                        numsOfLetters += currentIndex+nextMatchCurrentIndex.ToString();
                                        isOneMatch = true;

                                    }
                                    else
                                    {
                                        numsOfLetters += "," + (currentIndex + nextMatchCurrentIndex + k).ToString();
                                        isOneMatch = true;

                                    }
                                    
                                }
                                nextMatchCounter += currentIndex;
                            }
                            else
                            {
                                isOneMatch = false;

                            }
                        }
                    }


                }
                isOneMatch= false;

                for (int j = 0; j < wordsToSearchReverse.Length; j++)
                {
                    if (textArray[i].Contains(wordsToSearchReverse[j]))
                    {
                        int currentIndex = textArray[i].IndexOf(wordsToSearchReverse[j]);
                        int currentWordLength = wordsToSearchReverse[j].Length;

                        for (int k = 0; k < currentWordLength; k++)
                        {
                            if (string.IsNullOrEmpty(numsOfLetters))
                            {
                                numsOfLetters += currentIndex.ToString();
                                isOneMatch = true;

                            }
                            else
                            {
                                numsOfLetters += "," + (currentIndex + k).ToString();
                                isOneMatch = true;

                            }
                        }

                    }
                    else
                    {
                        isOneMatch = false;

                    }

                    int nextCurrentWordLengthReverse = wordsToSearchReverse[j].Length;
                    int nextMatchCurrentIndexReverse = textArray[i].IndexOf(wordsToSearchReverse[j]) + nextCurrentWordLengthReverse;
                    int nextMatchCounter = nextCurrentWordLengthReverse;

                    while (isOneMatch)                      
                    {
                        
                        for (int r =nextMatchCurrentIndexReverse; r <= textArray[i].Length; r+= nextMatchCounter)
                        {
                            String pieceTeaxtArray = textArray[i].Substring(r);
                            if (pieceTeaxtArray.Contains(wordsToSearchReverse[j]))
                            {

                                int currentIndex = pieceTeaxtArray.IndexOf(wordsToSearchReverse[j]);
                                int currentWordLength = wordsToSearchReverse[j].Length;

                                for (int k = 0; k < currentWordLength; k++)
                                {
                                    if (string.IsNullOrEmpty(numsOfLetters))
                                    {
                                        numsOfLetters += currentIndex + nextMatchCurrentIndexReverse.ToString();
                                        isOneMatch = true;

                                    }
                                    else
                                    {
                                        numsOfLetters += "," + (currentIndex + nextMatchCurrentIndexReverse + k).ToString();
                                        isOneMatch = true;

                                    }
                                    
                                }
                                nextMatchCounter += currentIndex;
                            }
                            else
                            {
                                isOneMatch = false;

                            }
                        }
                    }
                }



                String[] numsOfLettersArray = numsOfLetters.Split(',');
                Array.Sort(numsOfLettersArray);

                int[] numsOfLettersIntArray = new int[numsOfLettersArray.Length];

                for (int u = 0; u < numsOfLettersArray.Length; u++)
                {
                    numsOfLettersIntArray[u] = int.Parse(numsOfLettersArray[u]);
                }

                Array.Sort(numsOfLettersIntArray);
               

                for (int l = 0; l < numsOfLettersIntArray.Length; l++)
                {
                    for (int n = l + 1; n < numsOfLettersIntArray.Length; n++)
                    {
                        if (numsOfLettersIntArray[l] == numsOfLettersIntArray[n] && numsOfLettersIntArray[l] != -1)
                        {

                            numsOfLettersIntArray[l] = -1;
                            
                        }
                    }

                }

                for (int m = numsOfLettersIntArray.Length - 1; m >= 0; m--)
                {
                    if (numsOfLettersIntArray[m] != -1)
                    {
                        textArray[i] = textArray[i].Remove(numsOfLettersIntArray[m], 1);
                    }

                }

            }

            for (int i = 0; i < textArray.Length; i++) {
                secretMessage += textArray[i];
                
            }


            Console.WriteLine(secretMessage);
            Console.ReadLine();
        }
    }
}
