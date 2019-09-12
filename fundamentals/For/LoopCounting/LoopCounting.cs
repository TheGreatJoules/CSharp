using System;

namespace LoopCounting
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int j = 1; j < 5; j++)
			{
				for (int i = 1; i <= 10; i++)
				{
					Console.WriteLine(i);
				}
				
				for (int i = 10; i >= 1; i--)
				{
					Console.WriteLine(i);
				}
			}	
			
		}
	}
}