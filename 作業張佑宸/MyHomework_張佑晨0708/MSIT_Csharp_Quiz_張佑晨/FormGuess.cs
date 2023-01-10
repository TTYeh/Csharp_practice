using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MSIT_Csharp_Quiz_張佑晨
{
	// Token: 0x0200001B RID: 27
	public partial class FormGuess : Form
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00015374 File Offset: 0x00013574
		public FormGuess()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00015398 File Offset: 0x00013598
		private void button1_Click_1(object sender, EventArgs e)
		{
			Class1.x = this;
			Class1.ans = this.rand.Next(1, 100);
			FormGuessMessageBox formGuessMessageBox = new FormGuessMessageBox();
			formGuessMessageBox.ShowDialog();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000153CC File Offset: 0x000135CC
		private void button2_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(string.Format("Answer：{0}", Class1.ans));
		}

		// Token: 0x04000187 RID: 391
		private Random rand = new Random();
	}
}
