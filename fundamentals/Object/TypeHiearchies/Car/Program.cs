using System;
using System.Drawing;
using MyLibrary;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			object[] objects = {
				new M3(),
				new Hooptie(),
			};
			
			foreach (object obj in objects)
			{
				Console.WriteLine(obj);
				Is(obj);
				As(obj);
				Cast(obj);
				Console.WriteLine("- - - - - -");
			}
			
		}
		
		private static void Is(object obj)
		{
			bool isM3 = obj is M3;
			bool isICar = obj is ICar;
			Console.WriteLine("is M3 returned: {0}", isM3);
			Console.WriteLine("is ICar returned: {0}", isICar); 
		}
		
		private static void As(object obj)
		{
			M3 m3 = obj as M3;
			Console.WriteLine("as M3 returned: {0}", m3);
		}
		
		private static void Cast(object obj)
		{
			try {
				M3 m3 = (M3)obj;
				Console.WriteLine("(M3) return {0}", m3);
			} catch (InvalidCastException) {
				Console.WriteLine("InvalidCastException");
			}
			
		}
	}
}