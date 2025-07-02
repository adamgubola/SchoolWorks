using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Race
{
    internal class Race
    {
        private Team [] teams;

        public Team[] Teams
        {
            get { return teams; }
        }
        public Race (Team [] teams)
        {
            this.teams = teams;
        }

        public void Move()
        {
            for (int i = 0; i < Teams.Length; i++)
            {
                teams[i].Move();
            }
        }

        public bool End()
        {
            int endCounter = 0;

            for (int i = 0; i < Teams.Length; i++)
            {
                if (teams[i].End()) { endCounter++; };
            }
            if (endCounter >= teams.Length) return true;

            return false;
        }

        public string Display()
        {
            string result=string.Empty;

            for (int i = 0; i < Teams.Length; i++)
            {
                result += this.teams[i].Display() + "\n";
            }
            return result;
        }
        public Team[] Result()
        {
            Team[] tempTeam = new Team[this.teams.Length];
            
            for (int i = 0;i < tempTeam.Length; i++)
            {
                tempTeam[i] = this.teams[i];
            }
            Team temp;

            for (int i = 0;i< tempTeam.Length-1; i++) 
            {
               for (int j = i; j< tempTeam.Length; j++)
                {
                    if(tempTeam[i].sumTeamTime > tempTeam[j].sumTeamTime)
                    {
                        temp = tempTeam[i];
                        tempTeam[i] = tempTeam[j];
                        tempTeam[j] = temp;
                    }
                }
            }

            return tempTeam;
        }
        public string writeTeamMembers(Team[]teams)
        {
            string result = string.Empty;
            for (int i = 0; i < this.teams.Length; i++)
            {
                result += teams[i].MemberNames() + "\n";
            }
            return result;
        }

    }
}
