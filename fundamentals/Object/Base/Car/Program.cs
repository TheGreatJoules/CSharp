using System;
using System.Drawing;
using MyLibrary;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			object car = new M3();
			Type type = car.GetType();
			Console.WriteLine(type.Assembly.GetName().Version);
			Console.WriteLine(car);
			
		}
	}
}