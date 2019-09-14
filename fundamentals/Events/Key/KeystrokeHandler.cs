using System;

namespace MyApp
{
	public delegate void KeypressDelegate(char key);
	public delegate void QuitDelegate();
	/*
	 * Holding on to a delegate is enough to keep the object alive.
	 * Events are the prefer way to expose delegates (safety)
	 */
	public class KeystrokeHandler
	{
		public event KeypressDelegate OnKey;
		public event QuitDelegate OnQuitting;
		
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