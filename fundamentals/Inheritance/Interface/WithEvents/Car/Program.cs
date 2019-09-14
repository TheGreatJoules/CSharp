using System;
using System.Drawing;
using MyLibrary;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			ICar car = new M3();
			car.CarStopped += new EventHandler(OnCarStopped);
			car.Start();
			car.PressAccelerator(10);
			car.PressBrake(10);
			
		}
		
		static void PrintCarInfo(ICar car)
		{
			Console.WriteLine("Here is a {0} {1} {3}",
				car.Color.Name, car.Year, car.Make, car.Model);
		}
		
		static void OnCarStopped(object sender, EventArgs e)
		{
			Console.WriteLine("Car stopped!");
		}
	}
}