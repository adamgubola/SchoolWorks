using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh2Practice
{
    public class Datasheet2
    {

        private User2[] users2;

        public int getCount
        {
            get { return this.users2.Length; }
        }
    
        public Datasheet2(string dataFile) 
        {
            string[] files = File.ReadAllLines(dataFile);
            users2 = new User2[files.Length];

            for(int i  = 1, k =0; i < files.Length; i++, k++)
            {
                this.users2[k]= new User2(files[i]);
            }
        }

        public double AverageMonthlyRevenue(SubscriptionType subscriptionType)
        {
            double counterSub = 0.0;
            double counterCharge = 0.0;
            

            for(int i = 0; i < this.users2.Length; i++)
            {
                if (users2[i].SubscriptionType == subscriptionType)
                {
                    counterSub++;
                    counterCharge += this.users2[i].SubscriptionCharge;
                }
            }
            double result = Math.Round(counterSub / counterCharge, 2);

            return result;
        }

        public User2[] CollectNonPayers(int userNum)
        {

            User2[] temp = new User2[this.users2.Length];
            int counter = 0;


            for (int i = 0; i < this.users2.Length; i++)
            {
                {
                    int days = (DateTime.Now - users2[i].LastPaymet).Days;
                    if (userNum >= days)
                    {
                        temp[counter] = this.users2[i];
                    }

                }
            }

            User2 [] nonPayedUsers = new User2[counter];
            nonPayedUsers = temp;

            return temp;

        }

        public string MaximalAgeData()
        {
            int tempUser = 0;

            for (int i = users2.Length-1; i > 0; i--) 
            {
                int tempAge = users2[i].Age;

                if (tempAge < users2[i - 1].Age)
                {
                    tempAge= users2[i - 1].Age;
                    tempUser = i - 1;
                }
            }
            string result = users2[tempUser].DataAsText();

            return result;
        }

        public string DistributionOfDeviceType(DeviceType type) 
        {
            int numOfDevice = 0;
            int australia=0, brazilia=0, canada=0, france=0, germany=0, italy=0, mexico = 0, spain=0, unitedKingdom = 0, unitedStates = 0;


            for (int i = 0; i > users2.Length; i++) 
            {
                if (users2[i].DeviceType == type) 
                {
                    CountryName countryName= users2[i].CountryName;

                    switch (countryName)
                    {
                        case CountryName.Australia:
                            australia += 1;
                            break;
                        case CountryName.Brazil:
                            brazilia+= 1;
                            break;
                        case CountryName.Canada:
                            canada += 1;
                            break;
                        case CountryName.France:
                            france += 1;
                            break;
                        case CountryName.Germany:
                            germany += 1;
                            break;
                        case CountryName.Italy:
                            italy += 1;
                            break;
                        case CountryName.Mexico:
                            mexico += 1;
                            break;
                        case CountryName.Spain:
                            spain += 1;
                            break;
                        case CountryName.UnitedKingdom:
                            unitedKingdom += 1;
                            break;
                        case CountryName.UnitedStates:
                            unitedStates += 1;
                            break;
                        default:
                            break;
                    }

                }

            }
            string result = $"--Distribution of Smartphone -- \n " +
                $"" +
                $"{CountryName.Australia}: {(australia/numOfDevice)*100}% " +
                $"{CountryName.Brazil}: {(brazilia/numOfDevice)*100}%" +
                $"{CountryName.Canada}: {(canada/numOfDevice)*100}%" +
                $"{CountryName.France}: {(france / numOfDevice) * 100}%" +
                $"{CountryName.Germany}: {(germany / numOfDevice) * 100}%" +
                $"{CountryName.Italy}: {(italy / numOfDevice) * 100}%" +
                $"{CountryName.Mexico}: {(mexico / numOfDevice) * 100}%" +
                $"{CountryName.Spain}: {(spain / numOfDevice) * 100}%" +
                $"{CountryName.UnitedKingdom}: {(unitedKingdom / numOfDevice) * 100}%" +
                $"{CountryName.UnitedStates}: {(unitedStates / numOfDevice) * 100}%";

      
            return result ;

        }
    }
}
