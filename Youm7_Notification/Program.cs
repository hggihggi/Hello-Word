using System;
using System.Windows.Forms;

namespace Youm7_Notification
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Youm7());
		}
	}
}
