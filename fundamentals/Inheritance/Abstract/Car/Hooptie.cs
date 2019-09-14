using System;
using System.Drawing;

namespace MyLibrary
{
	public class Hooptie : Car
	{
		public Hooptie(): base ("Cadillac", "Coupe deVille",1956,Color.Black) {}
		
		public override void Start()
		{
			Console.WriteLine("Click click click click");
		}
		
		public override void PressAccelerator(double howFar)
		{
			if (howFar < 9)
			{
				// nothing happens
			}
			else
				Console.WriteLine("Cough!");
		}
		
		public override void PressBrake(double pressure)
		{
			if (pressure < 5)
				Console.WriteLine("Squeek");
			else
				Console.WriteLine("Grrrrriiiiinnnnnddddd");
		}
	}
}