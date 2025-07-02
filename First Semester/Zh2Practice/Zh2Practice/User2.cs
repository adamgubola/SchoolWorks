using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh2Practice
{
    public class User2
    {
        int id;
        SubscriptionType subscriptionType;
        int subscriptionCharge;
        DateTime connection;
        DateTime lastPaymet;
        CountryName countryName;
        int age;
        DeviceType deviceType;

        public int Id { get { return id; } }
        public SubscriptionType SubscriptionType { get { return subscriptionType; } }
        public int SubscriptionCharge { get { return subscriptionCharge; } }
        public DateTime Connection { get { return connection; } }

        public DateTime LastPaymet { get { return lastPaymet; } }
        public CountryName CountryName { get { return countryName; } }
        public DeviceType DeviceType { get {return deviceType;} }
        public int Age { get { return age; } }

        public User2(int id, SubscriptionType subscriptionType, int subscriptionCharge, 
            DateTime connection, DateTime lastPaymet, CountryName countryName, int age, DeviceType deviceType)
        {
            this.id = id;
            this.subscriptionType = subscriptionType;
            this.subscriptionCharge = subscriptionCharge;
            this.connection = connection;
            this.lastPaymet = lastPaymet;
            this.countryName = countryName;
            this.age = age;
            this.deviceType = deviceType;
        }

        public User2 (string id, string subscriptionType, string subscriptionCharge, string connection, string lastPaymet, 
            string countryName, string age, string deviceType): this (int.Parse(id), 
                (SubscriptionType)Enum.Parse(typeof(SubscriptionType), subscriptionType), int.Parse(subscriptionCharge),
                DateTime.Parse(connection), DateTime.Parse(lastPaymet), (CountryName)Enum.Parse(typeof(CountryName),countryName),
                int.Parse(age), (DeviceType)Enum.Parse(typeof(DeviceType),deviceType))
        {  }

        public User2(string[]userDatas) : this ( userDatas[0], userDatas[1],userDatas[2], userDatas[3],userDatas[4], userDatas[5],
                                            userDatas[6], userDatas[7])
        { }

        public User2(string datas) : this(datas.Split(',')) { }

        public int SubscriptionInDays()
        {
            int subDays= (DateTime.Now - this.connection).Days;

            return subDays;
        }

        public int DaysSinceLastPayment()
        {
            int payDays= (DateTime.Now - this.lastPaymet).Days;

            return payDays;
        }

        public string DataAsText()
        {
            string dataAsString = $"User ID: {id}({countryName}, {subscriptionType}, {deviceType}).Subscription: {SubscriptionInDays()}" +
                $" days, lastpayment: {DaysSinceLastPayment()} days.";

            return dataAsString;    
        }

    }
}
