using System;

namespace airport_challenge_c
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Plane p = new Plane ();
			p.Land ();
			Console.WriteLine (p.flying);
			p.isLanded ();
			p.TakeOff ();
			p.isLanded ();

			Console.WriteLine ();

			Airport a = new Airport ();
			a.Land ();
			a.planes ();
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
			Console.WriteLine (flying);
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
		public int[] planes = new int[80];

		public void Land ()
		{
			if(planes.length() >= 80)
			{
				Console.WriteLine ("The airport is full");
			} else {
				for (int plane = 0; plane <= 80; plane++)
				{
					planes[plane] = 1;
				}
			}
		}

	}
}
