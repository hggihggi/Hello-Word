using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Youm7_Notification.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"), CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
		public bool sound
		{
			get
			{
				return (bool)this["sound"];
			}
			set
			{
				this["sound"] = value;
			}
		}

		[DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode]
		public bool startup
		{
			get
			{
				return (bool)this["startup"];
			}
			set
			{
				this["startup"] = value;
			}
		}

		[DefaultSettingValue("0"), UserScopedSetting, DebuggerNonUserCode]
		public int language
		{
			get
			{
				return (int)this["language"];
			}
			set
			{
				this["language"] = value;
			}
		}
	}
}
