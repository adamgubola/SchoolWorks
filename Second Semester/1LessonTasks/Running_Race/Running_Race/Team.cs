using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Race
{
    internal class Team
    {
        private Runner[] runners;
        private static double allDistance = 42;
        string names = string.Empty;
        private int runnerNumber;
        public string MemberNames()
        {
            for (int i = 0; i < runners.Length; i++)
            {

                names += runners[i].Name + "\t";

            }
            return names;
        }
        public double sumTeamDistance
        {
            get            
                {
                    double dist = 0;

                    for (int i = 0; i < runners.Length; i++)
                    {
                        dist += runners[i].Distance;
                    }
                    return dist;
                }
        }

        public double sumTeamTime
        {
            get
            {
                int tempTime = 0;

                for (int i = 0; i < runners.Length; i++)
                {
                    tempTime += runners[i].Time;
                }
                return tempTime;
            }
        }

        public bool teamGiveUp
        { get
            {
               for (int i = 0; i<runners.Length; i++)
                {
               if (runners[i].GiveUp) return true;
                }
               return false;                
            }

        }
        public Team(Runner[] runners)
        {
            this.runners = runners;
        }
        
        public void Move()
        {
            if (teamGiveUp || sumTeamDistance >= allDistance) { return; }

            else if (this.runners.Length == 1)
            {
                runners[0].Move();
                runnerNumber = 0;
            }

            else if (this.runners.Length == 2)
            {
                if (this.sumTeamDistance < 21)
                {
                    runnerNumber = 0;
                    runners[0].Move();
                    

                }
                else if (this.sumTeamDistance >=21 && this.sumTeamDistance < 42)
                {
                    runnerNumber = 1;
                    runners[1].Move();

                }
            }

            else if (this.runners.Length == 3)
            {
                if (this.sumTeamDistance < 10)
                {
                    runnerNumber = 0;
                    runners[0].Move();

                }
                else if (this.sumTeamDistance >= 10 && this.sumTeamDistance < 30)
                {
                    runnerNumber = 1;
                    runners[1].Move();

                }
                else if (this.sumTeamDistance >= 30 && this.sumTeamDistance < 42)
                {
                    runnerNumber = 2;
                    runners[2].Move();

                }

            }

            else if (this.runners.Length == 5)
            {
                if (this.sumTeamDistance < 8)
                {
                    runners[0].Move();
                    runnerNumber = 0;

                }
                else if (this.sumTeamDistance >= 8 && this.sumTeamDistance < 18)
                {
                    runnerNumber = 1;
                    runners[1].Move();

                }
                else if (this.sumTeamDistance >= 18 && this.sumTeamDistance < 25)
                {
                    runnerNumber = 2;
                    runners[2].Move();

                }
                else if (this.sumTeamDistance >= 25 && this.sumTeamDistance < 36)
                {
                    runnerNumber = 3;
                    runners[3].Move();

                }
                else if (this.sumTeamDistance >= 36 && this.sumTeamDistance < 42)
                {
                    runnerNumber = 4;
                    runners[4].Move();

                }
            }
        }

        public bool End()
        {
            if(this.teamGiveUp || this.sumTeamDistance >= allDistance) return true;

            return false;
        }

        public string Display()
        {
            string result = "";

            for (int i = 0; i < allDistance; i++) 
            { 
                if(i == Math.Floor(sumTeamDistance))
                {
                    result += "X";
                }
                else
                {
                    result += " ";
                }
            
            }
            if (sumTeamDistance >= 42) result += "X";

            result += $"\t Futó neve: {this.runners[this.runnerNumber].Name}, \t {(this.teamGiveUp ? "Versenyben" : "Feladta")}" +
                $"\t táv:{Math.Round(this.sumTeamDistance)} \t idő:{this.sumTeamTime}";

            return result;
        }

       



    }
}
