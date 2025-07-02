using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Zh2Practice
{
    internal class Dataset
    {
        User[] users;


        public int UsersCount
        {
            get { return this.users.Length; }
        }


        public Dataset() { }

        public Dataset(string file)
        {
            string[] inputDatas = File.ReadAllLines(file);

            this.users = new User[inputDatas.Length-1];

            for (int i = 1; i < inputDatas.Length; i++)
            {

                this.users[i-1] = new User(inputDatas[i]);
            }

        }

        public string AverageMonthlyRevenue(SubscriptionType subscriptionType)
        {
            int counter = 0;
            double charge = 0.0;

            for (int i = 0; i < this.users.Length; i++)
            {
                if (this.users[i].SubscriptionType == subscriptionType)
                {
                    charge += this.users[i].SubscriptionCharge;
                    counter++;
                }
            }
            if (counter == 0)
            {
                return "0.0"; 
            }
            double result = charge / counter;


            return $"{result:F2}";
        }

        public User[] CollectNonPayers(int nonPayersNumber)
        {
            User[] nonPayedUsers = new User[this.users.Length];
            int counter = 0;

            for (int i = 0; i < this.users.Length; i++)
            {
                if (this.users[i].DaysSinceLastPayment() >= nonPayersNumber)
                {
                    nonPayedUsers[counter] = this.users[i];
                    counter++;
                }
            }

            User[] nonPayedUsersFinal = new User[counter];

            for (int i = 0; i < counter; i++)
            {
                nonPayedUsersFinal[i] = nonPayedUsers[i];
            }

            return nonPayedUsersFinal;

        }

        public User[] Resize(int index, ref User[] users)
        {
            User[] temp = new User[index];

            for (int i = 0; i < index; i++)
            {
                temp[i] = this.users[i];
            }

            this.users = temp;

            return this.users;
        }
        
    
        public string MaximalAgeData()
        {
            int maximalAgeUser=0;
            string oldestUser = "";

            for (int i = this.users.Length-1; i > 0; i--) 
            {
                int tempAge= this.users[i].Age;
                int tempUserNumber = i;

                if (this.users[i-1].Age>= tempAge)
                {
                    tempAge = this.users[i-1].Age;
                    tempUserNumber = i-1;
                }
                maximalAgeUser = tempUserNumber;
            }

            return this.users[maximalAgeUser].DataAsText();

        }

        public string DistributionOfDeviceType(DeviceType type)
        {
            CountryName countryName;
            double australia=0;
            double australiaNum=0;
            double brazil=0;
            double brazilNum=0;
            double canada=0;
            double canadaNum=0;
            double france=0;
            double franceNum=0;
            double germany=0;
            double germanyNum=0;
            double italy=0;
            double italyNum=0;
            double mexico=0;
            double mexicoNum=0;
            double spain=0;
            double spainNum=0;
            double uk=0;
            double ukNum=0;
            double usa=0;
            double usaNum=0;
            double allThisDevice = 0.0;

            for (int i = 0; i < this.users.Length; i++)
            {
                if (this.users[i].DeviceType==type)
                {
                    countryName= this.users[i].CountryName;
                    allThisDevice += 1;


                    switch (countryName)
                    {
                        case CountryName.Australia:
                            { australia += 1; }
                            break;
                        case CountryName.Brazil:
                            { brazil += 1; }
                            break;
                        case CountryName.Canada:
                            { canada += 1; }
                            break;
                        case CountryName.France:
                            { france += 1; }
                            break;
                        case CountryName.Germany:
                            { germany += 1; }
                            break;
                        case CountryName.Italy:
                            { italy += 1; }
                            break;
                        case CountryName.Mexico:
                            { mexico += 1; }
                            break;
                        case CountryName.Spain:
                            { spain += 1; }
                            break;
                        case CountryName.UnitedKingdom:
                            { uk += 1; }
                            break;
                        case CountryName.UnitedStates:
                            { usa += 1; }   
                            break;
                        default:
                            break;
                    }
                }
            }

            for (int i = 0; i < this.users.Length; i++)
            {
                countryName = this.users[i].CountryName;

                    switch (countryName)
                    {
                        case CountryName.Australia:
                            { australiaNum += 1; }
                            break;
                        case CountryName.Brazil:
                            { brazilNum += 1; }
                            break;
                        case CountryName.Canada:
                            { canadaNum += 1; }
                            break;
                        case CountryName.France:
                            { franceNum += 1; }
                            break;
                        case CountryName.Germany:
                            { germanyNum += 1; }
                            break;
                        case CountryName.Italy:
                            { italyNum += 1; }
                            break;
                        case CountryName.Mexico:
                            { mexicoNum += 1; }
                            break;
                        case CountryName.Spain:
                            { spainNum += 1; }
                            break;
                        case CountryName.UnitedKingdom:
                            { ukNum += 1; }
                            break;
                        case CountryName.UnitedStates:
                            { usaNum += 1; }
                            break;
                        default:
                            break;
                    }
                }
            

        string result = $"-- Distribution of Smartphone -- \n" +
            $"Australia: {(australia / allThisDevice) *100:F2} % \n" +
            $"Brazil: {(brazil / allThisDevice) * 100:F2} % \n" +
            $"Canada: {(canada / allThisDevice) * 100:F2} % \n" +
            $"France: {(france / allThisDevice) * 100:F2} % \n" +
            $"Germany: {(germany / allThisDevice) * 100:F2} % \n" +
            $"Italy: {(italy / allThisDevice) * 100:F2} % \n" +
            $"Mexico: {(mexico / allThisDevice) * 100:F2} % \n" +
            $"Spain: {(spain / allThisDevice) * 100:F2} % \n" +
            $"UnitedKingdom: {(uk / allThisDevice) * 100:F2} % \n" +
            $"UnitedStates: {(usa / allThisDevice) * 100:F2} % \n";


                return result;
        }

    }
}
