using System;

namespace _3Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    string[,] cards = new string[4, 13];
            //    int row = cards.GetLength(0);
            //    int col = cards.GetLength(1);


            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            if (i == 0 && j < 9)
            //            {
            //                int num = j + 1;

            //                cards[i, j] = "Kör " + num;
            //            }
            //            else if (i == 0 && j == 9) { cards[i, j] = "Kör Király"; }
            //            else if (i == 0 && j == 10) { cards[i, j] = "Kör Dáma"; }
            //            else if (i == 0 && j == 11) { cards[i, j] = "Kör Ász"; }
            //            else if (i == 0 && j == 12) { cards[i, j] = "Kör Jumbo"; }


            //            if (i == 1 && j < 9)
            //            {
            //                int num = j + 1;

            //                cards[i, j] = "Káró " + num;
            //            }
            //            else if (i == 1 && j == 9) { cards[i, j] = "Káró Király"; }
            //            else if (i == 1 && j == 10) { cards[i, j] = "Káró Dáma"; }
            //            else if (i == 1 && j == 11) { cards[i, j] = "Káró Ász"; }
            //            else if (i == 1 && j == 12) { cards[i, j] = "Káró Jumbo"; }

            //            if (i == 2 && j < 9)
            //            {
            //                int num = j + 1;

            //                cards[i, j] = "Pikk " + num;
            //            }
            //            else if (i == 2 && j == 9) { cards[i, j] = "Pikk Király"; }
            //            else if (i == 2 && j == 10) { cards[i, j] = "Pikk Dáma"; }
            //            else if (i == 2 && j == 11) { cards[i, j] = "Pikk Ász"; }
            //            else if (i == 2 && j == 12) { cards[i, j] = "Pikk Jumbo"; }

            //            if (i == 3 && j < 9)
            //            {
            //                int num = j + 1;

            //                cards[i, j] = "Tref " + num;
            //            }
            //            else if (i == 3 && j == 9) { cards[i, j] = "Tref Király"; }
            //            else if (i == 3 && j == 10) { cards[i, j] = "Tref Dáma"; }
            //            else if (i == 3 && j == 11) { cards[i, j] = "Tref Ász"; }
            //            else if (i == 3 && j == 12) { cards[i, j] = "Tref Jumbo"; }

            //        }
            //    }

            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            Console.Write(cards[i, j] + "\t");
            //        }
            //    }

            //    Random random = new Random();

            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            int rand = random.Next(j, col);

            //            string temp = cards[i, j];
            //            cards[i, j] = cards[i, rand];
            //            cards[i, rand] = temp;

            //        }
            //    }
            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            Console.WriteLine(cards[i, j]);
            //        }
            //    }






            //Console.WriteLine("Adj meg 4 szót");

            //string[] userInput = new string[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    userInput[i] = Console.ReadLine();
            //}
            //Console.WriteLine("add meg a keresett szót");

            //string userSearch=Console.ReadLine();
            //int result = 0;
            //bool boolResult = false;


            //    for (int i = 0; i < userInput.Length; i++)
            //    {
            //        if (userInput[i].Equals(userSearch) && result<1)
            //        {
            //            result = i;
            //            boolResult = true;

            //        }
            //    }
            //    if (boolResult)
            //    {
            //        Console.WriteLine("A keresett szó az " + result + "számú megadott szó");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nincs találat");
            //    }

            //        Console.WriteLine("Adj meg szavakat, ha nem szeretnél többet megadni írd hogy STOP");

            //        List<string> userList = new List<string>();
            //        bool boolResult = true;

            //        while (boolResult)
            //        {
            //            string userInput = Console.ReadLine();

            //            if (userInput.ToUpper().Equals("STOP"))
            //                {
            //                boolResult = false;
            //            }
            //            else
            //            {
            //            userList.Add(userInput);

            //            }

            //        }
            //        Console.WriteLine("add meg a keresett szót");

            //        string userSearch = Console.ReadLine();
            //        int result = 0;


            //        for (int i = 0; i < userList.Count; i++)
            //        {
            //            if (userList[i].Equals(userSearch) && result < 1)
            //            {
            //                result = i;
            //                boolResult = true;

            //            }
            //        }
            //        if (boolResult)
            //        {
            //            Console.WriteLine("A keresett szó az " + result + "számú megadott szó");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Nincs találat");
            //        }





            //   List<string> name = new List<string>();
            //   List<int> age = new List<int>();
            //   List<bool> experience = new List<bool>();


            //   for (int i = 0; i < 3; i++)
            //   {

            //       Console.WriteLine("Add meg a neved");
            //       Console.WriteLine(i);
            //       name.Add(Console.ReadLine());

            //       Console.WriteLine("Adda meg a korod");

            //       age.Add(int.Parse(Console.ReadLine()));

            //       Console.WriteLine("Adda meg van e tapasztalatod programozásban: igen/nem");


            //       string exp=Console.ReadLine();
            //       if (exp.ToLower().Equals("igen")){ experience.Add(true); }
            //       else { experience.Add(false); }
            //   }

            //   int avarage = 0;
            //   int totalAge = 0;

            //foreach (int i in age) {
            //       totalAge += i;

            //   }
            //   avarage = totalAge / age.Count;
            //   Console.WriteLine(avarage);

            //   totalAge = 0;
            //   avarage = 0;
            //   int with = 0;


            //    for (int i = 0; i < experience.Count; i++)
            //    {
            //        if (experience[i] == false)
            //        {
            //            totalAge += age[i];
            //            with++;
            //        }
            //    }
            //    avarage=totalAge / with;
            //    if (with > 0)
            //    {
            //        Console.WriteLine("A tapasztalat nélküliek életkora" + avarage);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mindenkinek van tapasztalata");
            //    }


            //    int oldest = 0;
            //    int mark = -1;

            //    for (int i = 0; i < experience.Count; i++)
            //    {
            //        if (experience[i] == true && oldest < age[i])
            //        {
            //            oldest = age[i];
            //            mark = i;

            //        }
            //    }
            //    if (mark > -1) {
            //        Console.WriteLine("A legidősebb programozó " + name[mark] + " aki " + age[mark] + " éves");    
            //        }
            //    else
            //    {
            //        Console.WriteLine("Nincs tapasztalattal rendelkező programozó");
            //    }


            //int[,] forMirror = new int [3, 3];
            //int counter = 1;


            //for (int i = 0; i < 3; i++) {
            //    for (int j = 0; j < 3; j++)
            //    {
            //        forMirror[i, j] = counter;
            //        counter++;
            //    }

            //}
            //for (int i = 0;i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    { 
            //        Console.Write(forMirror[i, j] + "\t");
            //    }
            //    Console.Write("\n");

            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(forMirror[j, i] + "\t");
            //    }
            //    Console.Write("\n");

            //}






            //    char[,] forMirror = new char[3, 4];
            //    int counter = 'a';


            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            forMirror[i, j] = (char)counter;
            //            counter++;
            //        }

            //    }
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write(forMirror[i, j] + "\t");
            //        }
            //        Console.Write("\n");

            //    }
            //    Console.Write("\n");

            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write(forMirror[j, i] + "\t");
            //        }
            //        Console.Write("\n");

            //    }





            //int[,] fishMans = new int[5, 10];
            //Random rnd = new Random();

            //for (int i = 0; i < fishMans.GetLength(0); i++) {

            //    for (int j = 0; j < fishMans.GetLength(1); j++) { 

            //        int random= rnd.Next(1,20);
            //        fishMans[i, j] = random;
            //    }
            //}

            //for (int i = 0; i < fishMans.GetLength(0); i++)
            //{

            //    for (int j = 0; j < fishMans.GetLength(1); j++)
            //    {

            //        Console.Write(fishMans[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");

            //}
            //Console.WriteLine("\n");

            //int countPerFish;
            //int tipe = 1;


            //for (int i = 0; i < fishMans.GetLength(1); i++)
            //{
            //    countPerFish = 0;

            //    for (int j = 0; j < fishMans.GetLength(0); j++)
            //    {

            //        countPerFish+= fishMans[j, i];
            //    }
            //    Console.WriteLine("Halfaj " + tipe +  ", össz darab: " + countPerFish);
            //    tipe++;

            //}
            //Console.WriteLine("\n");







            //List<int> numList = new List<int>();

            //Console.WriteLine("Kérlek adj meg egy pozitív egész számot");

            //numList.Add(int.Parse(Console.ReadLine()));

            //while (numList[numList.Count - 1] > 1)
            //{

            //    if (numList[numList.Count - 1] % 2 == 0)
            //    {
            //        numList.Add(numList[numList.Count - 1] / 2);
            //    }
            //    else
            //    {
            //        numList.Add(numList[numList.Count - 1] * 3 + 1);

            //    }
            //    Console.WriteLine(numList[numList.Count -1 ]);


            //}
            //Console.WriteLine("Az utolsó szám most " + numList[numList.Count - 1]);




            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < x.Length/2; i++)
            {
                int tmp = x[i];
                x[i] = x[x.Length-1-i];
                x[x.Length - 1-i] = tmp;
            }
            foreach (int i in x)
            Console.WriteLine(i);






        }

    }
}
