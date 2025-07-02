using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam
{
    internal class Program
    {
        static Player[] RandomPlayers(int count)
        {
            Random random = new Random();
            Player[] randomPlayers = new Player[count];


            string[] possibleNames = { "Alex", "Jordan", "Taylor", "Morgan", "Charlie", "Jamie", "Casey", "Drew", "Logan", "Riley" };
            for (int i = 0; i < count; i++)

            {
                int randInt = random.Next(0, 10);
                int randPos = random.Next(0, 4);
                randomPlayers[i] = new Player(possibleNames[randInt], (Position)randPos);

            }

            return randomPlayers;
        }


        static void Main(string[] args)
        {

            Team team = new Team(5);

            Console.WriteLine($"A random játékosok");
            int playerCounter = 0;

            Player[] randPlayers = Program.RandomPlayers(10);

            foreach (Player randomPlayer in randPlayers)
            {
                Console.WriteLine($" Játékos száma: {playerCounter} Adatai: {randomPlayer.ToString()}");
                playerCounter++;
            }

            do
            {
                Console.WriteLine("Írd be az álalad választott játékos számát");

                int userNumber = int.Parse(Console.ReadLine());

                team.isIncluded(randPlayers[userNumber]);

                if (team.isAvailale(randPlayers[userNumber]) && !team.isFull())
                {

                    team.include(randPlayers[userNumber]);

                }

            } while (!team.isFull());



        }
    }
}
