using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyHomework_張佑晨0704;
using MyHomework_張佑晨0705;

namespace MyHomework_張佑晨
{
	// Token: 0x02000010 RID: 16
	public partial class index : Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000F701 File Offset: 0x0000D901
		public index()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000F71C File Offset: 0x0000D91C
		private void button1_Click(object sender, EventArgs e)
		{
			Student_StructForm_0708 student_StructForm_ = new Student_StructForm_0708();
			student_StructForm_.Show();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000F738 File Offset: 0x0000D938
		private void button2_Click(object sender, EventArgs e)
		{
			Myhomework_0709_StudentsGrade myhomework_0709_StudentsGrade = new Myhomework_0709_StudentsGrade();
			myhomework_0709_StudentsGrade.Show();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000F754 File Offset: 0x0000D954
		private void button3_Click(object sender, EventArgs e)
		{
			Myhomework_0710_StudentsGrade_List myhomework_0710_StudentsGrade_List = new Myhomework_0710_StudentsGrade_List();
			myhomework_0710_StudentsGrade_List.Show();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000F770 File Offset: 0x0000D970
		private void button4_Click(object sender, EventArgs e)
		{
			Myhomework_0711_MyClac myhomework_0711_MyClac = new Myhomework_0711_MyClac();
			myhomework_0711_MyClac.Show();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000F78C File Offset: 0x0000D98C
		private void button5_Click(object sender, EventArgs e)
		{
			Myhomework_0711_Method myhomework_0711_Method = new Myhomework_0711_Method();
			myhomework_0711_Method.Show();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		private void button6_Click(object sender, EventArgs e)
		{
			Myhomework_0712_ForDoWhile myhomework_0712_ForDoWhile = new Myhomework_0712_ForDoWhile();
			myhomework_0712_ForDoWhile.Show();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		private void button7_Click(object sender, EventArgs e)
		{
			Myhomework_0704_Loan myhomework_0704_Loan = new Myhomework_0704_Loan();
			myhomework_0704_Loan.Show();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		private void button8_Click(object sender, EventArgs e)
		{
			Myhomework_0716_XOGame myhomework_0716_XOGame = new Myhomework_0716_XOGame();
			myhomework_0716_XOGame.Show();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		private void button9_Click(object sender, EventArgs e)
		{
			Myhomework_0703_Hello myhomework_0703_Hello = new Myhomework_0703_Hello();
			myhomework_0703_Hello.Show();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000F818 File Offset: 0x0000DA18
		private void button10_Click(object sender, EventArgs e)
		{
			Myhomework_0705_POShp myhomework_0705_POShp = new Myhomework_0705_POShp();
			myhomework_0705_POShp.Show();
		}
	}
}
