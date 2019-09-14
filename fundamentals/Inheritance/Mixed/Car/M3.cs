using System;
using System.Drawing;

namespace MyLibrary
{
	public class M3 : CarBase
	{
		public M3() : base("BMW", "M3", 2008, Color.Silver){}
		
		public override void PressAccelerator(double howFar)
		{
			Console.WriteLine("Vroom vroom!");
		}
		
		public override void PressBrake(double pressure)
		{
			Console.WriteLine("Stopped on a dime!");
		}
	}
}