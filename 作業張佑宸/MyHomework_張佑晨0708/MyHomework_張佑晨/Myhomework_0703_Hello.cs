using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x02000004 RID: 4
	public partial class Myhomework_0703_Hello : Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public Myhomework_0703_Hello()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003D0C File Offset: 0x00001F0C
		private void Hello_Click(object sender, EventArgs e)
		{
			MessageBox.Show(string.Concat(new string[]
			{
				"Hello, 我是",
				this.ChiName.Text,
				", \n英文名字是 ",
				this.EnName.Text,
				"\n性別是",
				this.sex.Text,
				", \n星座是",
				this.cons.Text,
				", \n很高興認識你。"
			}));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003D8C File Offset: 0x00001F8C
		private void Hi_Click(object sender, EventArgs e)
		{
			MessageBox.Show(string.Concat(new string[]
			{
				"Hi, 我是",
				this.ChiName.Text,
				", \n英文名字是 ",
				this.EnName.Text,
				"\n性別是",
				this.sex.Text,
				", \n星座是",
				this.cons.Text,
				", \n很高興認識你。"
			}));
		}
	}
}
