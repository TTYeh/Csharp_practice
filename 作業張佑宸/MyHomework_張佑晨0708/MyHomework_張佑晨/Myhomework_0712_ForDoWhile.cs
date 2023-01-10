using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x02000009 RID: 9
	public partial class Myhomework_0712_ForDoWhile : Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000A368 File Offset: 0x00008568
		public Myhomework_0712_ForDoWhile()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000A40C File Offset: 0x0000860C
		private static void OddOrEven(int num, out string oddeven)
		{
			bool flag = num % 2 == 0;
			string arg;
			if (flag)
			{
				arg = " 偶數";
			}
			else
			{
				arg = " 奇數";
			}
			oddeven = string.Format("輸入的數 {0}為 {1}。", num, arg);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000A450 File Offset: 0x00008650
		private static void OdOrEnCount(int[] array, out int odcount, out int encount)
		{
			odcount = 0;
			encount = 0;
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i] % 2 == 0;
				if (flag)
				{
					encount++;
				}
				else
				{
					odcount++;
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000A498 File Offset: 0x00008698
		private static void arrayMaxMin(int[] array, out int arrMax, out int arrMin)
		{
			arrMax = array[0];
			arrMin = array[array.Length - 1];
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i] > arrMax;
				if (flag)
				{
					arrMax = array[i];
				}
				bool flag2 = array[i] < arrMin;
				if (flag2)
				{
					arrMin = array[i];
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000A4EC File Offset: 0x000086EC
		private static void arrayStrLongest(string[] array, out string longestname)
		{
			longestname = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i].Length > longestname.Length;
				if (flag)
				{
					longestname = array[i];
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000A530 File Offset: 0x00008730
		private static void os1ins0(ref int[,] grid, out string gridstring)
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					bool flag = i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1;
					if (flag)
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 1);
					}
					else
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 0);
					}
				}
				gridstring += "\n ";
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000A60C File Offset: 0x0000880C
		private static void os0ins1(ref int[,] grid, out string gridstring)
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					bool flag = i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1;
					if (flag)
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 0);
					}
					else
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 1);
					}
				}
				gridstring += "\n ";
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A6E8 File Offset: 0x000088E8
		private static void o10s10(ref int[,] grid, out string gridstring)
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					bool flag = i % 2 == 0;
					if (flag)
					{
						bool flag2 = j % 2 == 0;
						if (flag2)
						{
							gridstring += string.Format("{0,2} ", grid[i, j] = 1);
						}
						else
						{
							gridstring += string.Format("{0,2} ", grid[i, j] = 0);
						}
					}
					else
					{
						bool flag3 = j % 2 == 0;
						if (flag3)
						{
							gridstring += string.Format("{0,2} ", grid[i, j] = 0);
						}
						else
						{
							gridstring += string.Format("{0,2} ", grid[i, j] = 1);
						}
					}
				}
				gridstring += "\n ";
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000A81B File Offset: 0x00008A1B
		private static void show_error()
		{
			MessageBox.Show("請輸入數值");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000A82C File Offset: 0x00008A2C
		private static void swaparr(ref int x, ref int y)
		{
			int num = x;
			x = y;
			y = num;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A844 File Offset: 0x00008A44
		private static void sumarr(int[] array, out int arrSum)
		{
			arrSum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				arrSum += array[i];
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A874 File Offset: 0x00008A74
		private static void maxarr(int[] array, out int arrMax)
		{
			arrMax = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i] > arrMax;
				if (flag)
				{
					arrMax = array[i];
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		private static void minarr(int[] array, out int arrMin)
		{
			arrMin = array[array.Length - 1];
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i] < arrMin;
				if (flag)
				{
					arrMin = array[i];
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		private static int SumFor(int from, int to, int step)
		{
			int num = 0;
			while (from <= to)
			{
				num += from;
				from += step;
			}
			return num;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000A920 File Offset: 0x00008B20
		private static int SumWhile(int from, int to, int step)
		{
			int num = 0;
			while (from <= to)
			{
				num += from;
				from += step;
			}
			return num;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000A950 File Offset: 0x00008B50
		private static int SumDo(int from, int to, int step)
		{
			int num = 0;
			do
			{
				num += from;
				from += step;
			}
			while (from <= to);
			return num;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000A97C File Offset: 0x00008B7C
		private static string SingleSideTree(int rows)
		{
			string text = "";
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					bool flag = j <= i;
					if (flag)
					{
						text += "*";
					}
					else
					{
						text += " ";
					}
				}
				text += "\n";
			}
			return text;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		private void button1_Click(object sender, EventArgs e)
		{
			int num;
			bool flag = int.TryParse(this.textBox1.Text, out num);
			if (flag)
			{
				string text;
				Myhomework_0712_ForDoWhile.OddOrEven(num, out text);
				this.labelResult.Text = text;
			}
			else
			{
				Myhomework_0712_ForDoWhile.show_error();
				this.textBox1.Focus();
				this.textBox1.SelectAll();
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000AA52 File Offset: 0x00008C52
		private void Clearbutton_Click(object sender, EventArgs e)
		{
			this.labelResult.Text = "結果";
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000AA68 File Offset: 0x00008C68
		private void button2_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			Myhomework_0712_ForDoWhile.OdOrEnCount(this.arr0711, out num, out num2);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("奇數共 {0}\n偶數共 {1}", num, num2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		private void button3_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			Myhomework_0712_ForDoWhile.arrayMaxMin(this.arr0711, out num, out num2);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("最大值為 {0}\n最小值為 {1}", num, num2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000AB00 File Offset: 0x00008D00
		private void button4_Click(object sender, EventArgs e)
		{
			string str;
			Myhomework_0712_ForDoWhile.arrayStrLongest(this.arr0711_Str, out str);
			this.labelResult.Text = "陣列arr0711_Str [ mother張,emma,迪克蕭,J40]\n最長的名字為" + str;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000AB34 File Offset: 0x00008D34
		private void button5_Click(object sender, EventArgs e)
		{
			string text = "";
			Myhomework_0712_ForDoWhile.os1ins0(ref this.grid0711, out text);
			this.labelResult.Text = text;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000AB64 File Offset: 0x00008D64
		private void button6_Click(object sender, EventArgs e)
		{
			string text = "";
			Myhomework_0712_ForDoWhile.os0ins1(ref this.grid0711, out text);
			this.labelResult.Text = text;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000AB94 File Offset: 0x00008D94
		private void button7_Click(object sender, EventArgs e)
		{
			string text = "";
			Myhomework_0712_ForDoWhile.o10s10(ref this.grid0711, out text);
			this.labelResult.Text = text;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		private void button8_Click(object sender, EventArgs e)
		{
			int num = 100;
			int num2 = 200;
			this.labelResult.Text = string.Format("換位前n1={0} , n2={1}", num, num2);
			Myhomework_0712_ForDoWhile.swaparr(ref num, ref num2);
			Label label = this.labelResult;
			label.Text += string.Format("\n換位後n1={0} , n2={1}", num, num2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000AC34 File Offset: 0x00008E34
		private void button9_Click(object sender, EventArgs e)
		{
			int num;
			Myhomework_0712_ForDoWhile.sumarr(this.arr0711, out num);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("加總為 {0}", num);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000AC78 File Offset: 0x00008E78
		private void button10_Click(object sender, EventArgs e)
		{
			int num;
			Myhomework_0712_ForDoWhile.maxarr(this.arr0711, out num);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("最大值為 {0}", num);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000ACBC File Offset: 0x00008EBC
		private void button11_Click(object sender, EventArgs e)
		{
			int num;
			Myhomework_0712_ForDoWhile.minarr(this.arr0711, out num);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("最小值為 {0}", num);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000AD00 File Offset: 0x00008F00
		private void button12_Click(object sender, EventArgs e)
		{
			int num = 0;
			this.labelResult.Text = "arr0711_Str陣列：";
			for (int i = 0; i < this.arr0711_Str.Length; i++)
			{
				Label label = this.labelResult;
				label.Text = label.Text + "    " + this.arr0711_Str[i];
				bool flag = this.arr0711_Str[i].IndexOf("C") != -1 || this.arr0711_Str[i].IndexOf("c") != -1;
				if (flag)
				{
					num++;
				}
			}
			Label label2 = this.labelResult;
			label2.Text += string.Format("\n有C 及 c的名字共有 {0} 個", num);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		private void button13_Click(object sender, EventArgs e)
		{
			this.labelResult.Text = "九九乘法表\n";
			for (int i = 1; i <= 9; i++)
			{
				for (int j = 2; j <= 9; j++)
				{
					Label label = this.labelResult;
					label.Text += string.Format("{0,2}x{1,2}={2,2}|", j, i, j * i);
				}
				Label label2 = this.labelResult;
				label2.Text += "\n";
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000AE5C File Offset: 0x0000905C
		private void button14_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			int num3;
			bool flag = int.TryParse(this.textBoxFrom.Text, out num) && int.TryParse(this.textBoxTo.Text, out num2) && int.TryParse(this.textBoxStep.Text, out num3);
			if (flag)
			{
				this.labelResult.Text = string.Format("{0} 到 {1} 相隔 {2}\n加總為 {3}", new object[]
				{
					num,
					num2,
					num3 - 1,
					Myhomework_0712_ForDoWhile.SumFor(num, num2, num3)
				});
			}
			else
			{
				Myhomework_0712_ForDoWhile.show_error();
				this.textBoxFrom.Focus();
				this.textBoxFrom.SelectAll();
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000AF18 File Offset: 0x00009118
		private void button15_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			int num3;
			bool flag = int.TryParse(this.textBoxFrom.Text, out num) && int.TryParse(this.textBoxTo.Text, out num2) && int.TryParse(this.textBoxStep.Text, out num3);
			if (flag)
			{
				this.labelResult.Text = string.Format("{0} 到 {1} 相隔 {2}\n加總為 {3}", new object[]
				{
					num,
					num2,
					num3 - 1,
					Myhomework_0712_ForDoWhile.SumWhile(num, num2, num3)
				});
			}
			else
			{
				Myhomework_0712_ForDoWhile.show_error();
				this.textBoxFrom.Focus();
				this.textBoxFrom.SelectAll();
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000AFD4 File Offset: 0x000091D4
		private void button16_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			int num3;
			bool flag = int.TryParse(this.textBoxFrom.Text, out num) && int.TryParse(this.textBoxTo.Text, out num2) && int.TryParse(this.textBoxStep.Text, out num3);
			if (flag)
			{
				this.labelResult.Text = string.Format("{0} 到 {1} 相隔 {2}\n加總為 {3}", new object[]
				{
					num,
					num2,
					num3 - 1,
					Myhomework_0712_ForDoWhile.SumDo(num, num2, num3)
				});
			}
			else
			{
				Myhomework_0712_ForDoWhile.show_error();
				this.textBoxFrom.Focus();
				this.textBoxFrom.SelectAll();
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B090 File Offset: 0x00009290
		private void button17_Click(object sender, EventArgs e)
		{
			int rows;
			bool flag = int.TryParse(this.textBoxRows.Text, out rows);
			if (flag)
			{
				this.labelResult.Text = Myhomework_0712_ForDoWhile.SingleSideTree(rows);
			}
			else
			{
				Myhomework_0712_ForDoWhile.show_error();
				this.textBoxRows.Focus();
				this.textBoxRows.SelectAll();
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B0EC File Offset: 0x000092EC
		private void button18_Click(object sender, EventArgs e)
		{
			int num = 100;
			this.labelResult.Text = "";
			while (num / 2 > 0)
			{
				this.labelResult.Text = num % 2 + this.labelResult.Text;
				num /= 2;
			}
			bool flag = num / 2 == 0;
			if (flag)
			{
				this.labelResult.Text = num + this.labelResult.Text;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B174 File Offset: 0x00009374
		private void button19_Click(object sender, EventArgs e)
		{
			int[] array = new int[6];
			this.labelResult.Text = "樂透號碼\n";
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this.lotteryrandom.Next(1, 49);
				for (int j = 0; j < i; j++)
				{
					while (array[j] == array[i])
					{
						array[i] = this.lotteryrandom.Next(1, 49);
						j = 0;
					}
				}
				Label label = this.labelResult;
				label.Text += string.Format(" {0}", array[i]);
			}
		}

		// Token: 0x0400008B RID: 139
		private int[] arr0711 = new int[]
		{
			1,
			5,
			6,
			8,
			7,
			97,
			54,
			887,
			65,
			578
		};

		// Token: 0x0400008C RID: 140
		private string[] arr0711_Str = new string[]
		{
			"mother張",
			"emma",
			"迪克蕭",
			"J40",
			"Candy",
			"Cindy",
			"Coconut",
			"Motherfacker"
		};

		// Token: 0x0400008D RID: 141
		private int[,] grid0711 = new int[10, 10];

		// Token: 0x0400008E RID: 142
		private Random lotteryrandom = new Random();
	}
}
