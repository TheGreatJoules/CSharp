using System;

namespace Survey
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine("What is your name?");
			var name = TryAgain();
			
			Console.WriteLine("What is your age?");
			var age = TryAgain();
		
			Console.WriteLine("What month were you born in?");
			var month = TryAgain();
			
			Console.WriteLine("Your name is: {0}", name);
			Console.WriteLine("Your age is: {0}", age);
			Console.WriteLine("Your birthday month is: {0}", month);
			
			if (month == "march")
				Console.WriteLine("You are an Aries.");
			else if (month == "april")
				Console.WriteLine("You are an Taurus");
			else if (month == "may")
				Console.WriteLine("You are an Gemini");
		}
		
		static string TryAgain()
		{
			var answer = Console.ReadLine();
			if (answer == "")
			{
				Console.WriteLine("You didn't write anything, please try again.");
				return Console.ReadLine();
			}
			
			return answer;
			
		}
	}
}