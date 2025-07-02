using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportWatch
{
    public class Workout
    {
		private string type;
		private double distance;
		private Time time;
		private int elevation;
		private int heartRate;

		public int HeartRate
		{
			get { return heartRate; }
			set { heartRate = value; }
		}


		public int Elevation
		{
			get { return elevation; }
			private set { elevation = value; }
		}


		public Time Time
		{
			get { return time; }
			private set { time = value; }
		}


		public double Distance
		{
			get { return distance; }
			private set { distance = value; }
		}

		public string Type
		{
			get { return type; }
			private set { type = value; }
		}

        public Workout(string type, double distance, Time time, int elevation, int heartRate)
        {
            this.type = type;
            this.distance = distance;
            this.time = time;
            this.elevation = elevation;
            this.heartRate = heartRate;
        }

        public static Workout Parse(string inp)
		{
			Workout workout = null;
			try
			{
                string temp = inp.Replace('"', ' ');
                string[] splitted = temp.Split(',');

                workout = new Workout(splitted[0].Trim(),
                                    double.Parse(splitted[1].Trim(), CultureInfo.InvariantCulture),
                                    Time.Parse(splitted[2].Trim()),
                                    int.Parse(splitted[3].Trim()),
                                    int.Parse(splitted[4].Trim()));
            }
			catch (Exception e)
			{

				Console.WriteLine($"Az adatok beolvasása során hiba lépett fel: {e.Message}");
				throw new WorkoutException();

			}

			return workout;
			
		}
        public override string ToString()
        {
            return $"{this.Type}, {this.Distance}, {this.Time}, {this.Elevation}, {this.HeartRate}";
        }

    }
}
