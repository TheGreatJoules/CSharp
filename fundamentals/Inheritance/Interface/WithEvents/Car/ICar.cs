 using System;
using System.Drawing;

// interface is public by default
namespace MyLibrary
{
	public interface ICar
	{
		void Start();
		void PressAccelerator(double howFar);
		void PressBrake(double pressure);
		string Make { get; }
		string Model { get; }
		int Year { get; }
		Color Color { get; set; }
		event EventHandler CarStopped;
	}
	
	
	
}