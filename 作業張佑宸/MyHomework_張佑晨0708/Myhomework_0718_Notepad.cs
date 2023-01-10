using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyHomework_張佑晨0708
{
	// Token: 0x02000015 RID: 21
	public partial class Myhomework_0718_Notepad : Form
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000125CF File Offset: 0x000107CF
		public Myhomework_0718_Notepad()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000125E8 File Offset: 0x000107E8
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00012610 File Offset: 0x00010810
		private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Myhomework_0718_Notepad_About myhomework_0718_Notepad_About = new Myhomework_0718_Notepad_About();
			myhomework_0718_Notepad_About.ShowDialog();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0001262C File Offset: 0x0001082C
		private void 說明LToolStripButton_Click(object sender, EventArgs e)
		{
			Myhomework_0718_Notepad_About myhomework_0718_Notepad_About = new Myhomework_0718_Notepad_About();
			myhomework_0718_Notepad_About.ShowDialog();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00012647 File Offset: 0x00010847
		private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.Cut();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00012656 File Offset: 0x00010856
		private void 剪下UToolStripButton_Click(object sender, EventArgs e)
		{
			this.textBox1.Cut();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00012665 File Offset: 0x00010865
		private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.Copy();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00012674 File Offset: 0x00010874
		private void 複製CToolStripButton_Click(object sender, EventArgs e)
		{
			this.textBox1.Copy();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00012683 File Offset: 0x00010883
		private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.Paste();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00012692 File Offset: 0x00010892
		private void 貼上PToolStripButton_Click(object sender, EventArgs e)
		{
			this.textBox1.Paste();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000126A4 File Offset: 0x000108A4
		private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Myhomework_0718_Notepad myhomework_0718_Notepad = new Myhomework_0718_Notepad();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000126B8 File Offset: 0x000108B8
		private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.openFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName);
				this.textBox1.Text = streamReader.ReadToEnd();
				streamReader.Close();
				streamReader.Dispose();
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001270C File Offset: 0x0001090C
		private void 開啟OToolStripButton_Click(object sender, EventArgs e)
		{
			bool flag = this.openFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName);
				this.textBox1.Text = streamReader.ReadToEnd();
				streamReader.Close();
				streamReader.Dispose();
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00012760 File Offset: 0x00010960
		private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.colorDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.textBox1.ForeColor = this.colorDialog1.Color;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001279C File Offset: 0x0001099C
		private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.fontDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.textBox1.Font = this.fontDialog1.Font;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000127D5 File Offset: 0x000109D5
		private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.SelectAll();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000127E4 File Offset: 0x000109E4
		private void 新增NToolStripButton_Click(object sender, EventArgs e)
		{
			Myhomework_0718_Notepad myhomework_0718_Notepad = new Myhomework_0718_Notepad();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000127F8 File Offset: 0x000109F8
		private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text.ToUpper();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00012817 File Offset: 0x00010A17
		private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text.ToLower();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00012836 File Offset: 0x00010A36
		private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.WordWrap = !this.textBox1.WordWrap;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00012853 File Offset: 0x00010A53
		private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001285D File Offset: 0x00010A5D
		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.ForeColor = Color.Red;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00012871 File Offset: 0x00010A71
		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.ForeColor = Color.Green;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00012885 File Offset: 0x00010A85
		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.ForeColor = Color.Blue;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00012899 File Offset: 0x00010A99
		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.textBox1.ForeColor = Color.Black;
		}
	}
}
