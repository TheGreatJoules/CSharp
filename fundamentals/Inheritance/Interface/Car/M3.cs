using System;
using System.Drawing;

namespace MyLibrary
{
	public class M3: ICar
	{
		public void Start()
		{
			Console.WriteLine("Roar!");
		}
		
		public void PressAccelerator(double howFar)
		{
			Console.WriteLine("Vroom vroom!");
		}
		
		public void PressBrake(double pressure)
		{
			Console.WriteLine("Stopped on a dime!");
		}
		
		public string Make
		{
			get { return "BMW"; }
		}
		
		public string Model
		{
			get { return "M3"; }
		}
		
		public int Year
		{
			get { return 2008; }
		}
		
		public Color Color { get; set; }
	}
}