using System;
using System.Windows.Forms;
using MyHomework_張佑晨0708;

namespace MyHomework_張佑晨
{
	// Token: 0x0200000C RID: 12
	internal static class HomeIndex
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000E81F File Offset: 0x0000CA1F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new HomePage());
		}
	}
}
