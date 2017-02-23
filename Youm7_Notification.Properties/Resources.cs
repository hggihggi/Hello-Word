using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Youm7_Notification.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Youm7_Notification.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		internal static Bitmap About
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("About", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Ar
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Ar", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static byte[] DroidKufi_Bold
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("DroidKufi_Bold", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		internal static byte[] DroidKufi_Regular
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("DroidKufi_Regular", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		internal static Bitmap En
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("En", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Exit
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Exit", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap GRAY_Arrow_Left
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("GRAY_Arrow_Left", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap GRAY_Arrow_Right
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("GRAY_Arrow_Right", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Inner_Logo
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Inner_Logo", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Lock
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Lock", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Pc_Start
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Pc_Start", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap RED_Arrow_02
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("RED_Arrow_02", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap RED_Arrow_Left
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("RED_Arrow_Left", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Site
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Site", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Sound_Off
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Sound_Off", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Sound_On
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Sound_On", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static UnmanagedMemoryStream sounds_954_all_eyes_on_me
		{
			get
			{
				return Resources.ResourceManager.GetStream("sounds_954_all_eyes_on_me", Resources.resourceCulture);
			}
		}

		internal static Bitmap UNLock
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("UNLock", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap Youm_7_Notification_BOX_Updated
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Youm_7_Notification_BOX_Updated", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Icon Youm7_square_logo
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Youm7_square_logo", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		internal static Icon Youm7_square_logo_mute
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Youm7_square_logo_mute", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
