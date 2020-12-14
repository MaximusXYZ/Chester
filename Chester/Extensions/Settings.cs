using Microsoft.Win32;
using System;
using System.Linq;

class Settings
{
	private static Settings GetSettings;
	private RegistryKey Key;

	public static Settings Instance
	{
		get
		{
			Settings settings;
			if ((settings = Settings.GetSettings) == null)
				settings = (Settings.GetSettings = new Settings("Chester"));
			return settings;
		}
	}

	public Settings(string Class)
	{
		Key = Registry.CurrentUser.OpenSubKey($"Software\\{Class}", true);
		if (this.Key == null) this.Key = Registry.CurrentUser.CreateSubKey($"Software\\{Class}");
	}

	public bool TopMost
	{
		get
		{
			if (!Key.GetValueNames().Contains("TopMost")) this.Key.SetValue("TopMost", false);

			return Convert.ToBoolean(this.Key.GetValue("TopMost"));
		}
		set => Key.SetValue("TopMost", value);
	}

	public bool ShadowCheats
	{
		get
		{
			if (!Key.GetValueNames().Contains("ShadowCheats")) this.Key.SetValue("ShadowCheats", true);

			return Convert.ToBoolean(this.Key.GetValue("ShadowCheats"));
		}
		set => Key.SetValue("ShadowCheats", value);
	}

	public bool EasyExploits
	{
		get
		{
			if (!Key.GetValueNames().Contains("EasyExploits")) this.Key.SetValue("EasyExploits", false);

			return Convert.ToBoolean(this.Key.GetValue("EasyExploits"));
		}
		set => Key.SetValue("EasyExploits", value);
	}
}
