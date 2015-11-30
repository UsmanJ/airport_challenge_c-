using System;
using System.Collections.Generic;

namespace airport_challenge_c
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Airport a = new Airport ();
			Plane p = new Plane ();
			Plane p1 = new Plane ();
			Plane p2 = new Plane ();
			a.Land ();
			p.Land ();
			a.Land ();
			p1.Land ();
			a.Land ();
			p2.Land ();
			p.isFlying ();
			p.isLanded ();
			p.TakeOff ();
			p.isLanded ();

			Console.WriteLine ();

			a.ReleasePlane ();
			Console.WriteLine (a.planes.Count + " Planes at the airport");
			a.ReleasePlane ();
			Console.WriteLine (a.planes.Count + " Planes at the airport");
			a.ReleasePlane ();
			Console.WriteLine (a.planes.Count + " Planes at the airport");
			a.ReleasePlane ();

		}
	}

	class Plane
	{
		public bool flying = true;

		public void Land ()
		{
			if (flying == false) {
				Console.WriteLine ("Plane is already landed");
			} else {
				flying = false;
				Console.WriteLine ("Plane has landed");
			}
		}

		public void TakeOff ()
		{
			if (flying == true) {
				Console.WriteLine ("Plane is already airbourne");
			} else {
				flying = true;
				Console.WriteLine ("Plane has taken off");
			}		
		}

		public void isFlying ()
		{
			Console.WriteLine ("Plane flying = " + flying);
		}

		public void isLanded	()
		{
			if (flying == false) 
			{
				Console.WriteLine ("Plane is currently landed");
			} else {
				Console.WriteLine ("Plane is currently airbourne");
			}
		}
	}

	class Airport
	{
		public List<int> planes = new List<int> ();

		public void Land ()
		{
			if(planes.Count >= 80)
			{
				Console.WriteLine ("The airport is full");
			} else {
				planes.Add (1);
				Console.WriteLine ("Plane landing");
			}
		}

		public void ReleasePlane ()
		{
			if(planes.Count <= 0)
			{
				Console.WriteLine ("There are no planes on the airfield");
			} else {
				planes.Remove (1);
				Console.WriteLine ("Plane released");
			}
		}

	}
}