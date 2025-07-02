using System;

namespace PMPHF012_D0JE27
{
    internal class Program
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

            for (int i = 0; i < rowsForTables; i++) { wordsForTables[i] = Console.ReadLine().ToLower(); }


            Tables tables = new Tables(wordsForTables, rowsForTables, colsForTables);

            tables.searchHorizontal(tables, searchedWords);
            tables.searchDiagonalFromDownLeft(tables, searchedWords);
            tables.searchDiagonalFromTopRight(tables, searchedWords);
            tables.searchVertival(tables, searchedWords);
            tables.searchDiagonalFromDownRight(tables, searchedWords);
            tables.searchDiagonalFromTopLeft(tables, searchedWords);




            //Console.WriteLine("\n");

            //tables.PrintTables(tables);

            //searchedWords.Write();

            Console.WriteLine(tables.SearchForSmallLetters(tables));





        }




    }
}
