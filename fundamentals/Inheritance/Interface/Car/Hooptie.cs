using System;
using System.Drawing;

namespace MyLibrary
{
	public class Hooptie : ICar
	{
		public void Start()
		{
			Console.WriteLine("Click click click click");
		}
		
		public void PressAccelerator(double howFar)
		{
			if (howFar < 9)
			{
				// nothing happens
			}
			else Console.WriteLine("Cough!");
		}
		
		public void PressBrake(double pressure)
		{
			if (pressure < 5)
				Console.WriteLine("Squeek");
			else 
				Console.WriteLine("Grrrrriiiiinnnnnddddd");
		}
		
		public string Make { get { return "Cadillac"; }}
		public string Model { get {return "Coupe deVille"; }}
		public int Year { get { return 1956; }}
		public Color Color { get; set;  }
	}
}