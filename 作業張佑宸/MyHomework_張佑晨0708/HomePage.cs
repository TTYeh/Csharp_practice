using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MSIT_Csharp_Quiz_張佑晨;
using MSIT_Csharp_Quiz_張佑晨_Alarm;
using MyHomework_張佑晨;
using MyHomework_張佑晨0704;
using MyHomework_張佑晨0705;

namespace MyHomework_張佑晨0708
{
	// Token: 0x02000013 RID: 19
	public partial class HomePage : Form
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000FFC2 File Offset: 0x0000E1C2
		public HomePage()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000FFDC File Offset: 0x0000E1DC
		private void button1_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0703_Hello myhomework_0703_Hello = new Myhomework_0703_Hello();
			myhomework_0703_Hello.TopLevel = false;
			myhomework_0703_Hello.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0703_Hello);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0001002C File Offset: 0x0000E22C
		private void button2_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0704_Loan myhomework_0704_Loan = new Myhomework_0704_Loan();
			myhomework_0704_Loan.TopLevel = false;
			myhomework_0704_Loan.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0704_Loan);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0001007C File Offset: 0x0000E27C
		private void button3_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0705_POShp myhomework_0705_POShp = new Myhomework_0705_POShp();
			myhomework_0705_POShp.TopLevel = false;
			myhomework_0705_POShp.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0705_POShp);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000100CC File Offset: 0x0000E2CC
		private void button4_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Student_StructForm_0708 student_StructForm_ = new Student_StructForm_0708();
			student_StructForm_.TopLevel = false;
			student_StructForm_.Show();
			this.splitContainer2.Panel2.Controls.Add(student_StructForm_);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0001011C File Offset: 0x0000E31C
		private void button8_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0709_StudentsGrade myhomework_0709_StudentsGrade = new Myhomework_0709_StudentsGrade();
			myhomework_0709_StudentsGrade.TopLevel = false;
			myhomework_0709_StudentsGrade.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0709_StudentsGrade);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0001016C File Offset: 0x0000E36C
		private void button7_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0710_StudentsGrade_List myhomework_0710_StudentsGrade_List = new Myhomework_0710_StudentsGrade_List();
			myhomework_0710_StudentsGrade_List.TopLevel = false;
			myhomework_0710_StudentsGrade_List.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0710_StudentsGrade_List);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000101BC File Offset: 0x0000E3BC
		private void button6_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0711_Method myhomework_0711_Method = new Myhomework_0711_Method();
			myhomework_0711_Method.TopLevel = false;
			myhomework_0711_Method.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0711_Method);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0001020C File Offset: 0x0000E40C
		private void button5_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0711_MyClac myhomework_0711_MyClac = new Myhomework_0711_MyClac();
			myhomework_0711_MyClac.TopLevel = false;
			myhomework_0711_MyClac.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0711_MyClac);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0001025C File Offset: 0x0000E45C
		private void button16_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0712_ForDoWhile myhomework_0712_ForDoWhile = new Myhomework_0712_ForDoWhile();
			myhomework_0712_ForDoWhile.TopLevel = false;
			myhomework_0712_ForDoWhile.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0712_ForDoWhile);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000102AC File Offset: 0x0000E4AC
		private void button15_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0716_XOGame myhomework_0716_XOGame = new Myhomework_0716_XOGame();
			myhomework_0716_XOGame.TopLevel = false;
			myhomework_0716_XOGame.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0716_XOGame);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000102FC File Offset: 0x0000E4FC
		private void button14_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0718_ScreenSaver myhomework_0718_ScreenSaver = new Myhomework_0718_ScreenSaver();
			myhomework_0718_ScreenSaver.Show();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00010330 File Offset: 0x0000E530
		private void button10_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			FormGuess formGuess = new FormGuess();
			formGuess.TopLevel = false;
			formGuess.Show();
			this.splitContainer2.Panel2.Controls.Add(formGuess);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00010380 File Offset: 0x0000E580
		private void button9_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			FormAlarm formAlarm = new FormAlarm();
			formAlarm.TopLevel = false;
			formAlarm.Show();
			this.splitContainer2.Panel2.Controls.Add(formAlarm);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000103D0 File Offset: 0x0000E5D0
		private void button13_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0718_Notepad myhomework_0718_Notepad = new Myhomework_0718_Notepad();
			myhomework_0718_Notepad.Show();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00010404 File Offset: 0x0000E604
		private void button12_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			Myhomework_0723_DrawPaint myhomework_0723_DrawPaint = new Myhomework_0723_DrawPaint();
			myhomework_0723_DrawPaint.TopLevel = false;
			myhomework_0723_DrawPaint.Show();
			this.splitContainer2.Panel2.Controls.Add(myhomework_0723_DrawPaint);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00010454 File Offset: 0x0000E654
		private void button11_Click(object sender, EventArgs e)
		{
			this.splitContainer2.Panel2.Controls.Clear();
			MyHomework_0722_PictureViewer myHomework_0722_PictureViewer = new MyHomework_0722_PictureViewer();
			myHomework_0722_PictureViewer.TopLevel = false;
			myHomework_0722_PictureViewer.Show();
			this.splitContainer2.Panel2.Controls.Add(myHomework_0722_PictureViewer);
		}
	}
}
