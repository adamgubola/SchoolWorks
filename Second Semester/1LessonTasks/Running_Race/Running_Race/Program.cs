using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Running_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Team team1 = new Team(new Runner[] {new Runner("A", 7) });
            Team team2 = new Team(new Runner[] { new Runner("B", 4), new Runner("C",5 ) });
            Team team3 = new Team(new Runner[] { new Runner("D", 6), new Runner("E", 3), new Runner("F", 5) });

            Race race = new Race(new Team[] { team1,  team2, team3 });

            while (!race.End())
            {
                Console.Clear();
                race.Move();
                Console.WriteLine(race.Display());
                Thread.Sleep(50);
            }
            Team[] tempTeam = race.Result();
            
            race.writeTeamMembers(tempTeam);
        }



    
    }
}
