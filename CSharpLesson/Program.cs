using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson {
	class Program {
			struct gamer {
			public string name;
			public int favnbr;
			};

		static void Main(string[] args) {
			int a = 23;
			int b = a * 37;
			int c = b - 41;
			int d = c / 7;
			string aStr = d.ToString();
			//Console.WriteLine(d);

			string name = "Jon";
			int days = 6;

			Console.WriteLine("My name is " + name + ". I've been in this bootcamp for " + days.ToString() + " days.");

			DateTime Bdate = new DateTime(1992, 06, 25);
			DateTime Tday = DateTime.Today;
			double DaysAlive = (Tday - Bdate).TotalDays;
			Console.WriteLine("You have been alive for " + DaysAlive + " days.");

			if(Tday > Bdate) {
				Console.WriteLine(Tday);
			} else {
				Console.WriteLine(Bdate);
			}

			int[] BowlingFrames = new int[10];
			int n = 0;
			Random Rnd = new Random();
			int TotalScore = 0;
			while(n < 10) {
				BowlingFrames[n] = Rnd.Next(1,30);
				TotalScore = TotalScore + BowlingFrames[n];
				n++;
			}
			TotalScore = BowlingFrames.Sum();
			Console.WriteLine(TotalScore);

			TotalScore = 0;

			foreach(int BowlingFrame in BowlingFrames) {
				TotalScore = TotalScore + BowlingFrame;
			};
			Console.WriteLine(TotalScore);

			string[] names = {
				"Greg", "Michael", "Dan", "Anna", "Foster", "Marcus", "William","Larry","Jon","Mitchell","Jermaine"
			};

			foreach(string aName in names) {
				Console.WriteLine("Hi " + aName);
			};

			String[] PIs= {
				"Jonathan Wilson","Silverton", "OH", "jon.wilsond@gmail.com"
			};
			//string city="Test";
			//string vals ;
			//foreach(string PI in PIs) {
			//	vals = PI;
			//	if(vals = "Silverton") {
			//		city = vals;
			//		continue;
			//	};
			//	if(vals = "OH") {
			//		Console.WriteLine(city + ", " + PI);
			//		continue;
			//	};
			//	Console.WriteLine(PI);

			gamer ken;
			ken.name = "Ken";
			ken.favnbr = 10;
			gamer nick;
			nick.name = "Nick";
			nick.favnbr = 7;

			gamer[] gamers = {
				ken, nick
			};

			foreach(gamer gmr in gamers) {
				Console.WriteLine("{0}'s favorite number is {1}", gmr.name, gmr.favnbr);
			}
		}
	}
}
