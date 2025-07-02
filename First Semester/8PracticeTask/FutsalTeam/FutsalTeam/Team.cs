using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam
{
    internal class Team
    {
        Player[] players;
        Player[] Player { get; set; }

        int numOfPlayers;

        public Team(int teamSize)
        {
            players = new Player[teamSize];
        }

    
        public bool isFull()
        {

            if (numOfPlayers == players.Length) 
            { 
                Console.WriteLine("A csapat megtelt");
                return true;
            } 
            else
            {
                return false;
            }

        }

        int counterInclude = 0;
        int counterIsEmpty = 0;

        public bool isIncluded(Player player)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == null)
                {
                    counterIsEmpty++;
                    if (counterIsEmpty == players.Length) { Console.WriteLine("A csapat üres"); }

                    return false;
                }

                else if (player.position == Position.Forward && players[i].position == player.position ||
                         player.position == Position.Defender && players[i].position == player.position ||
                         player.position == Position.Goalkeeper && players[i].position == player.position)
                {
                    Console.WriteLine("Ezt a pozíciót már tartalmazza a csapat");
                    return false;
                }

                else if (player.position == Position.Winger && players[i].position == player.position)
                {
                    counterInclude++;
                    if (counterInclude >= 2)
                    {
                        Console.WriteLine("Ezt a pozíciót már tartalmazza a csapat");
                        return false;
                    }
                }
            }

            return true;
        }




        int counterAvailable = 0;

        public bool isAvailale(Player player)
        {
            for (int i = 0; i < players.Length; i++)
            {

                if (players[i] == null)
                {
                    return true;
                }

                else if(player.position== Position.Winger && players[i].position== player.position)
                {
                    counterAvailable++;
                    if (counterAvailable >= 2)
                    {
                        Console.WriteLine("Ez a pozíció már nem elérhető");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                else if (player.position== Position.Forward && players[i].position == player.position || 
                         player.position == Position.Defender && players[i].position == player.position ||
                         player.position == Position.Goalkeeper && players[i].position == player.position)
                {
                    Console.WriteLine("Ez a pozíció már nem elérhető");
                    return false;
                }
            }

            return true;
        }

        public void include(Player player)
        {

                if (players[numOfPlayers] == null)
                {
                players[numOfPlayers] = new Player(player.Name, player.position);

                Console.WriteLine(player.ToString());

                    numOfPlayers++;
                }
                
                else if( numOfPlayers<5) 
                {
                players[numOfPlayers] =  new Player(player.Name, player.position);
                Console.WriteLine(player.ToString());

                numOfPlayers++;
                }
                else { Console.WriteLine("A csapat megtelt"); }


        }
    }
}
