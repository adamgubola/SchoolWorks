using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF012_D0JE27
{
    internal class PMPHF012_D0JE27
    {

        static void Main(string[] args)
        {

            int searchedWordsNumber = int.Parse(Console.ReadLine());

            SearchedWords searchedWords = new SearchedWords(searchedWordsNumber);


            for (int i = 0; i < searchedWordsNumber; i++)
            {
                searchedWords.AddWord(Console.ReadLine().ToLower());
            }

            string[] tablesDimensions = Console.ReadLine().Split(' ');

            int rowsForTables = int.Parse(tablesDimensions[0]);
            int colsForTables = int.Parse(tablesDimensions[1]);

            string[] wordsForTables = new string[rowsForTables];

            for (int i = 0; i < rowsForTables; i++) { wordsForTables[i] = Console.ReadLine(); }


            Tables tables = new Tables(wordsForTables, rowsForTables, colsForTables);

            tables.searchHorizontal(tables, searchedWords);
            tables.searchDiagonalFromDownLeft(tables, searchedWords);
            tables.searchDiagonalFromTopRight(tables, searchedWords);
            tables.searchVertival(tables, searchedWords);
            tables.searchDiagonalFromDownRight(tables, searchedWords);
            tables.searchDiagonalFromTopLeft(tables, searchedWords);






            Console.WriteLine(tables.SearchForLetters(tables));





        }

        internal class Tables
        {

            char[,] tables;
            bool[,] marked;


            public char[,] getTables() { return tables; }
            public bool[,] GetMarked() { return marked; }

            public Tables(string[] words, int rows, int cols)
            {
                tables = new char[rows, cols];
                marked = new bool[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        tables[i, j] = words[i][j];
                        marked[i, j] = false;
                    }
                }
            }
            public Tables(char[,] updatedTable)
            {
                tables = updatedTable;
            }

            public void searchHorizontal(Tables tables, SearchedWords wordsToSearch)
            {
                string normalSearc;
                string reverseSearch = "";
                string searchIn = "";

                for (int i = 0; i < wordsToSearch.getSearchedWords().Length; i++)
                {

                    normalSearc = "";
                    normalSearc = wordsToSearch.getSearchedWords()[i].ToLower();
                    reverseSearch = "";

                    for (int j = normalSearc.Length - 1; j >= 0; j--) { reverseSearch += normalSearc[j]; }

                    for (int k = 0; k < tables.tables.GetLength(0); k++)
                    {
                        searchIn = "";

                        for (int l = 0; l < tables.tables.GetLength(1); l++)
                        {
                            searchIn += char.ToLower(tables.tables[k, l]);

                        }

                        if (searchIn.ToLower().Contains(normalSearc))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(normalSearc);
                            int currentWordLength = normalSearc.Length;


                            for (int m = currentIndex; m < currentWordLength + currentIndex; m++)
                            {
                                tables.marked[k, m] = true;
                            }

                            wordsToSearch.RemoveWord(normalSearc.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }
                        if (searchIn.ToLower().Contains(reverseSearch))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(reverseSearch);
                            int currentWordLength = reverseSearch.Length;

                            for (int m = currentIndex + currentWordLength - 1; m >= currentIndex; m--)
                            {
                                tables.marked[k, m] = true;
                            }
                            wordsToSearch.RemoveWord(reverseSearch.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }

                    }

                }


            }

            public void searchDiagonalFromDownLeft(Tables tables, SearchedWords wordsToSearch)
            {
                string normalSearc;
                string reverseSearch = "";
                string searchIn = "";

                int rows = tables.tables.GetLength(0);
                int cols = tables.tables.GetLength(1);

                for (int i = 0; i < wordsToSearch.getSearchedWords().Length; i++)
                {

                    normalSearc = "";
                    normalSearc = wordsToSearch.getSearchedWords()[i].ToLower();
                    reverseSearch = "";

                    for (int j = normalSearc.Length - 1; j >= 0; j--) { reverseSearch += normalSearc[j]; }

                    searchIn = "";


                    for (int startRow = rows - 1; startRow >= 0; startRow--)
                    {

                        int currentRow = startRow;
                        int actualCol = 0;
                        searchIn = "";


                        while (currentRow < rows && actualCol < cols)
                        {

                            searchIn += char.ToLower(tables.tables[currentRow, actualCol]);
                            currentRow++;
                            actualCol++;
                        }

                        if (searchIn.ToLower().Contains(normalSearc))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(normalSearc);
                            int currentWordLength = normalSearc.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = startRow + k;
                                int colIndex = k;


                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(normalSearc.ToLower());
                            normalSearc = "";
                            reverseSearch = "";
                        }
                        if (searchIn.ToLower().Contains(reverseSearch))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(reverseSearch);
                            int currentWordLength = reverseSearch.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = startRow + k;
                                int colIndex = k;


                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(reverseSearch.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }
                    }
                }
            }

            public void searchDiagonalFromTopRight(Tables tables, SearchedWords wordsToSearch)
            {
                string normalSearc;
                string reverseSearch = "";
                string searchIn = "";

                int rows = tables.tables.GetLength(0);
                int cols = tables.tables.GetLength(1);

                for (int i = 0; i < wordsToSearch.getSearchedWords().Length; i++)
                {
                    normalSearc = wordsToSearch.getSearchedWords()[i].ToLower();
                    reverseSearch = "";

                    for (int j = normalSearc.Length - 1; j >= 0; j--) { reverseSearch += normalSearc[j]; }

                    for (int startCol = cols - 1; startCol >= 0; startCol--)
                    {
                        int currentRow = 0;
                        int actualCol = startCol;
                        searchIn = "";

                        while (currentRow < rows && actualCol < cols)
                        {
                            searchIn += char.ToLower(tables.tables[currentRow, actualCol]);
                            currentRow++;
                            actualCol++;
                        }

                        if (searchIn.ToLower().Contains(normalSearc))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(normalSearc);
                            int currentWordLength = normalSearc.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = k;
                                int colIndex = startCol + k;

                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(normalSearc.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }

                        if (searchIn.ToLower().Contains(reverseSearch))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(reverseSearch);
                            int currentWordLength = reverseSearch.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = k;
                                int colIndex = startCol + k;

                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(reverseSearch.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }
                    }
                }
            }


            public void searchVertival(Tables tables, SearchedWords wordsToSearch)
            {
                string normalSearc;
                string reverseSearch = "";
                string searchIn = "";

                for (int i = 0; i < wordsToSearch.getSearchedWords().Length; i++)
                {

                    normalSearc = "";
                    normalSearc = wordsToSearch.getSearchedWords()[i].ToLower();
                    reverseSearch = "";

                    for (int j = normalSearc.Length - 1; j >= 0; j--) { reverseSearch += normalSearc[j]; }

                    for (int k = 0; k < tables.tables.GetLength(1); k++)
                    {
                        searchIn = "";

                        for (int l = 0; l < tables.tables.GetLength(0); l++)
                        {
                            searchIn += char.ToLower(tables.tables[l, k]);

                        }

                        if (searchIn.ToLower().Contains(normalSearc))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(normalSearc);
                            int currentWordLength = normalSearc.Length;


                            for (int m = currentIndex; m < currentWordLength + currentIndex; m++)
                            {
                                tables.marked[m, k] = true;
                            }

                            wordsToSearch.RemoveWord(normalSearc.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }
                        if (searchIn.ToLower().Contains(reverseSearch))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(reverseSearch);
                            int currentWordLength = reverseSearch.Length;

                            for (int m = currentIndex + currentWordLength - 1; m >= currentIndex; m--)
                            {
                                tables.marked[m, k] = true;
                            }
                            wordsToSearch.RemoveWord(reverseSearch.ToLower());
                            normalSearc = "";
                            reverseSearch = "";

                        }

                    }

                }
            }

            public void searchDiagonalFromTopLeft(Tables tables, SearchedWords wordsToSearch)
            {
                string normalSearc;
                string reverseSearch = "";
                string searchIn = "";

                int rows = tables.tables.GetLength(0);
                int cols = tables.tables.GetLength(1);

                for (int i = 0; i < wordsToSearch.getSearchedWords().Length; i++)
                {
                    normalSearc = wordsToSearch.getSearchedWords()[i].ToLower();
                    reverseSearch = "";

                    for (int j = normalSearc.Length - 1; j >= 0; j--) { reverseSearch += normalSearc[j]; }

                    for (int startCol = 0; startCol < cols; startCol++)
                    {
                        int currentRow = 0;
                        int actualCol = startCol;
                        searchIn = "";

                        while (currentRow < rows && actualCol >= 0)
                        {
                            searchIn += char.ToLower(tables.tables[currentRow, actualCol]);
                            currentRow++;
                            actualCol--;
                        }

                        if (searchIn.ToLower().Contains(normalSearc))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(normalSearc);
                            int currentWordLength = normalSearc.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = k;
                                int colIndex = startCol - k;

                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(normalSearc.ToLower());
                            normalSearc = "";
                            reverseSearch = "";
                        }

                        if (searchIn.ToLower().Contains(reverseSearch))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(reverseSearch);
                            int currentWordLength = reverseSearch.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = k;
                                int colIndex = startCol - k;

                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(reverseSearch.ToLower());
                            normalSearc = "";
                            reverseSearch = "";
                        }
                    }
                }
            }

            public void searchDiagonalFromDownRight(Tables tables, SearchedWords wordsToSearch)
            {
                string normalSearc;
                string reverseSearch = "";
                string searchIn = "";

                int rows = tables.tables.GetLength(0);
                int cols = tables.tables.GetLength(1);

                for (int i = 0; i < wordsToSearch.getSearchedWords().Length; i++)
                {
                    normalSearc = wordsToSearch.getSearchedWords()[i].ToLower();
                    reverseSearch = "";

                    for (int j = normalSearc.Length - 1; j >= 0; j--) { reverseSearch += normalSearc[j]; }

                    for (int startCol = cols - 1; startCol >= 0; startCol--)
                    {
                        int currentRow = rows - 1;
                        int actualCol = startCol;
                        searchIn = "";

                        while (currentRow >= 0 && actualCol < cols)
                        {
                            searchIn += char.ToLower(tables.tables[currentRow, actualCol]);
                            currentRow--;
                            actualCol++;
                        }

                        if (searchIn.ToLower().Contains(normalSearc))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(normalSearc);
                            int currentWordLength = normalSearc.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = (rows - 1) - k;
                                int colIndex = startCol + k;

                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(normalSearc.ToLower());
                            normalSearc = "";
                            reverseSearch = "";
                        }

                        if (searchIn.ToLower().Contains(reverseSearch))
                        {
                            int currentIndex = searchIn.ToLower().IndexOf(reverseSearch);
                            int currentWordLength = reverseSearch.Length;

                            for (int k = 0; k < currentIndex + currentWordLength; k++)
                            {
                                int rowIndex = (rows - 1) - k;
                                int colIndex = startCol + k;

                                if (k >= currentIndex && k < currentIndex + currentWordLength)
                                {
                                    tables.marked[rowIndex, colIndex] = true;
                                }
                            }
                            wordsToSearch.RemoveWord(reverseSearch.ToLower());
                            normalSearc = "";
                            reverseSearch = "";
                        }
                    }
                }
            }


            public string SearchForLetters(Tables tables)
            {
                string secretMessage = "";

                for (int i = 0; i < tables.tables.GetLength(0); i++)
                {
                    for (int j = 0; j < tables.tables.GetLength(1); j++)
                    {
                        if (!tables.GetMarked()[i, j])
                        {
                            secretMessage += tables.tables[i, j];
                        }
                    }
                }
                return secretMessage;
            }

            public void PrintTables(Tables tables)
            {
                for (int i = 0; i < tables.tables.GetLength(0); i++)
                {
                    for (int j = 0; j < tables.tables.GetLength(1); j++) { Console.Write(tables.tables[i, j]); }
                    Console.Write("\n");
                }
            }



        }

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
                    searchedWords[count] = word;
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
                    if (searchedWords[i].Equals(word) && word.Length > 0)
                    {
                        this.searchedWords[i] = "";
                    }
                }
            }




            public void Write() { foreach (string word in searchedWords) { Console.WriteLine(word); } }
        }


    }
}
