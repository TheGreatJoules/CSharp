using System;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Loading settings...");
			MySettings settings = MySettings.Load();
			Console.WriteLine("MyNumber = {0}", settings.MyNumber);
			Console.WriteLine("MyString = {0}", settings.MyString);
			
			Console.WriteLine();
			Console.WriteLine("Updating settings and saving files");
			settings.MyNumber++;
			settings.MyString = DateTime.Now.ToString();
			settings.Save();
		}
	}
}