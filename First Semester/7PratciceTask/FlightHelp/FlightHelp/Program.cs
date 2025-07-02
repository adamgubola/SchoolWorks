using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHelp
{

    enum Status
    {
        Scheduled, Delayed, Canceled
    }


    class Flight
    {
        string flightNumber;
        public string FlihtNumber { get { return flightNumber; } }

        string destination;
        public string Destination { get { return destination; } }

        DateTime dateTime;
        public DateTime DateTime { get { return dateTime; } }

        int delayMinutes;
        public int DelayMinutes { get { return delayMinutes; } }

        Status status;
        public Status Status { get { return status; } }



        public Flight (string flightNumber,  string destination, DateTime dateTime, int delayMinutes)
        {
            this.flightNumber = flightNumber;
            this.destination = destination;
            this.dateTime = dateTime;
            this.delayMinutes = delayMinutes;
        }

        public Flight(string flightNumber, string destination, DateTime dateTime) : this(flightNumber, destination,
            dateTime, 0)
        { }

        public void Delay(int addDelayMinutes) 
        { 
        this.delayMinutes=addDelayMinutes;
        }

        public void Cancel()
        {
            this.status = Status.Canceled;
        }

        public void UpdateStatus(Status status)
        {
            this.status = status;
        }

        public void UpdateStatus()
        {
            if (this.delayMinutes > 0)
            {
            this.status= Status.Delayed;
            }
            else
            {
                this.status = Status.Scheduled;
            }
        }

        public string AllData()
        {
            if (this.status == Status.Canceled) 
                { 
                string cancel = "is canceled.";
                return ($"{flightNumber} {cancel} ");
                }

            else if (this.status == Status.Scheduled) 
            { string schedul = "is on time.";
                return ($"{flightNumber} {schedul} {this.dateTime.ToString("F")}");
            }
            else if (this.status == Status.Delayed) 
            { string delay = $"is delayed by {delayMinutes} minutes";
                return ($"{flightNumber} {delay} {this.dateTime.ToString("F")}");
            }

          return "Nincs járat";

        }

        public string EstrimatedDeparture()
        {
            if (this.delayMinutes < 0)
            {
                DateTime lateStart = this.dateTime.AddSeconds(-this.delayMinutes);


                return lateStart.ToString("F");
            }
            return null ;
        }

    }


    class GroundControl
    {
        DateTime timeNow;
        List<Flight> flights=new List<Flight>();

        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public int AvarageDelay()
        {
            int allDelay = 0;

            foreach (Flight flight in flights)
            {
                allDelay += flight.DelayMinutes;
            }
            return allDelay;
        }

        public void DisplayFlightData()
        {
            foreach (Flight flight in flights)
            {

                Console.WriteLine(flight.AllData());
            }
            Console.WriteLine($"Avarage delay is { AvarageDelay()}");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {

            Flight flight1= new Flight("Flight 123", "Budapest", DateTime.Now);
            Flight flight2 = new Flight("Flight 456", "Milano", DateTime.Now, 10);
            Flight flight3 = new Flight("Flight 789", "Párizs", DateTime.Now);

            GroundControl groundControl = new GroundControl();

            groundControl.AddFlight(flight1);
            groundControl.AddFlight(flight2);
            groundControl.AddFlight(flight3);

            flight1.Delay(20);
            flight1.UpdateStatus();
            flight3.Cancel();

            groundControl.DisplayFlightData();

        }
    }
}
