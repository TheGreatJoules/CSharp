using System;

namespace MyApp
{
	public delegate void KeypressDelegate(char key);
	public delegate void QuitDelegate();
	
	public class KeystrokeHandler
	{
		public KeypressDelegate OnKey;
		public QuitDelegate OnQuitting;
		
		public void Run()
		{
			Console.WriteLine("Keystroke handler is running. Press q to quit.");
			while (true)
			{
				char key = Console.ReadKey(true).KeyChar;
				if ('q' == key)
				{
					if (null != OnQuitting)
						OnQuitting();
					break;
				}
					
				if (null != OnKey)
					OnKey(key);
			}
		}
	}
}