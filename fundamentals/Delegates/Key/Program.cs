using System;
using System.Collections.Generic;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			QuitTracker bob = new QuitTracker { Name = "Bob" };
			QuitTracker sandy = new QuitTracker { Name = "Sandy" };
			KeystrokeHandler keystrokeHandler = new KeystrokeHandler();
			keystrokeHandler.OnKey = GotKey;
			keystrokeHandler.OnQuitting = bob.QuitHandler;
			keystrokeHandler.OnQuitting += sandy.QuitHandler;
			keystrokeHandler.OnQuitting += OnQuit;
			keystrokeHandler.Run();
		}
		
		static void GotKey(char key)
		{
			Console.WriteLine("Got a key: {0}", key);
		}
		
		static void OnQuit()
		{
			Console.WriteLine("Quitting!");
		}
	}
	
	public class QuitTracker
	{
		public string Name { get; set; }
		public void QuitHandler()
		{
			Console.WriteLine("My name is {0} and I just got a quit notification", Name);
		}
	}
}