using System;
using System.IO;
using System.Text;

namespace MyApp
{
	public class MySettings
	{
		public int MyNumber { get; set; }
		public string MyString { get; set; }
		
		public void Save()
		{
			Stream stream = File.Create(SettingsFile);
			StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
			writer.WriteLine(MyNumber);
			writer.WriteLine(MyString);
			writer.Close();
			stream.Close();
		}
		
		public static MySettings Load()
		{
			if (!File.Exists(SettingsFile))
				return DefaultSettings;
			Stream stream = File.OpenRead(SettingsFile);
			StreamReader reader = new StreamReader(stream, Encoding.UTF8);
			string firstLine = reader.ReadLine();
			string secondLine = reader.ReadLine();
			reader.Close();
			stream.Close();
			
			return new MySettings
			{
				MyNumber = int.Parse(firstLine),
				MyString = secondLine,
			};
		}
		
		private static string SettingsFolder
		{
			get
			{
				string folder = Environment.GetFolderPath(
					Environment.SpecialFolder.ApplicationData);
				folder = Path.Combine(folder, "MyCompany");
				folder = Path.Combine(folder, "MyApp");
				if (Directory.Exists(folder))
					Directory.CreateDirectory(folder);
				return folder;
			}
		}
		
		private static string SettingsFile
		{
			get
			{
				return Path.Combine(SettingsFolder, "settings.txt");
			}
		}
		
		private static MySettings DefaultSettings
		{
			get
			{
				return new MySettings
				{
					MyNumber = 0,
					MyString = "",
				};
			}
		}
	}
}