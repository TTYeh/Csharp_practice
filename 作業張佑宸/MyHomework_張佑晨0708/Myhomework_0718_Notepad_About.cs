using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨0708
{
	// Token: 0x02000016 RID: 22
	public partial class Myhomework_0718_Notepad_About : Form
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00014226 File Offset: 0x00012426
		public Myhomework_0718_Notepad_About()
		{
			this.InitializeComponent();
			this.label2.Text = "此版本為張佑晨在資策會C#的記事本作業1.0版，\n敬請您安心服用。";
			base.CenterToScreen();
		}
	}
}
