using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh2Practice
{
    internal class User
    {
        int id;
        SubscriptionType subscriptionType;
        int subscriptionCharge;
        DateTime connection;
        DateTime lastPayment;
        CountryName countryName;
        int age;
        DeviceType deviceType;



        public int Id { get { return this.id; } }
        public SubscriptionType SubscriptionType { get {return this.subscriptionType; } }
        public int SubscriptionCharge {get {return this.subscriptionCharge;} }
        public DateTime Connection {get {return this.connection;} }
        public DateTime LastPayment {get {return this.lastPayment;} }
        public CountryName CountryName {get {return this.countryName;} }
        public int Age {get {return this.age;} }
        public DeviceType DeviceType {get {return this.deviceType;} }

       


        public User(int id, SubscriptionType subscriptionType, int subscriptionCharge,
                   DateTime connection, DateTime lastPayment, CountryName countryName,
                   int age, DeviceType deviceType)
        {
            this.id = id;
            this.subscriptionType = subscriptionType;
            this.subscriptionCharge = subscriptionCharge;
            this.connection = connection;
            this.lastPayment = lastPayment;
            this.countryName = countryName;
            this.age = age;
            this.deviceType = deviceType;
        }
        public User(string id, string subscriptionType, string subscriptionCharge,
                   string connection, string lastPayment, string countryName, string age, string deviceType) 
                    : this (int.Parse(id), (SubscriptionType)Enum.Parse(typeof(SubscriptionType), subscriptionType), 
                    int.Parse(subscriptionCharge), DateTime.Parse(connection), DateTime.Parse(lastPayment), 
                    (CountryName)Enum.Parse(typeof(CountryName), countryName), int.Parse(age), 
                    (DeviceType)Enum.Parse(typeof(DeviceType), deviceType))
                               
        {}

        public User(string[]datas ) : this (datas[0], datas[1], datas[2], datas[3], datas[4], datas[5], datas[6], datas[7])
        {
        }
        public User(string data) : this(data.Split(','))
        {
        }
        
        public int SubscriptionInDays()
        {
            int subscriptionDays = (DateTime.Now - this.connection).Days;
            return subscriptionDays;
        }

        public int DaysSinceLastPayment()
        {
            int sinceLastPay = (DateTime.Now - this.lastPayment).Days;
            return sinceLastPay;
        }

        public string DataAsText()
        {
            return $"User Id: {this.Id} ({this.CountryName}, {this.Connection}, {this.DeviceType}). Subscription: " +
                $"{SubscriptionInDays()} days, last payment: {DaysSinceLastPayment()} days.";
        }
    }
}
