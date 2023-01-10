using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x02000008 RID: 8
	public partial class Myhomework_0711_Method : Form
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00008BDC File Offset: 0x00006DDC
		public Myhomework_0711_Method()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00008C74 File Offset: 0x00006E74
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

		// Token: 0x06000032 RID: 50 RVA: 0x00008CB8 File Offset: 0x00006EB8
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

		// Token: 0x06000033 RID: 51 RVA: 0x00008D00 File Offset: 0x00006F00
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

		// Token: 0x06000034 RID: 52 RVA: 0x00008D54 File Offset: 0x00006F54
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

		// Token: 0x06000035 RID: 53 RVA: 0x00008D98 File Offset: 0x00006F98
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

		// Token: 0x06000036 RID: 54 RVA: 0x00008E74 File Offset: 0x00007074
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

		// Token: 0x06000037 RID: 55 RVA: 0x00008F50 File Offset: 0x00007150
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

		// Token: 0x06000038 RID: 56 RVA: 0x00009084 File Offset: 0x00007284
		private static void swaparr(ref int x, ref int y)
		{
			int num = x;
			x = y;
			y = num;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000909C File Offset: 0x0000729C
		private static void sumarr(int[] array, out int arrSum)
		{
			arrSum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				arrSum += array[i];
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000090CC File Offset: 0x000072CC
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

		// Token: 0x0600003B RID: 59 RVA: 0x00009108 File Offset: 0x00007308
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

		// Token: 0x0600003C RID: 60 RVA: 0x00009148 File Offset: 0x00007348
		private void button1_Click(object sender, EventArgs e)
		{
			int num;
			bool flag = int.TryParse(this.textBox1.Text, out num);
			if (flag)
			{
				string text;
				Myhomework_0711_Method.OddOrEven(num, out text);
				this.labelResult.Text = text;
			}
			else
			{
				MessageBox.Show("請輸入數值");
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00009193 File Offset: 0x00007393
		private void Clearbutton_Click(object sender, EventArgs e)
		{
			this.labelResult.Text = "結果";
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000091A8 File Offset: 0x000073A8
		private void button2_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			Myhomework_0711_Method.OdOrEnCount(this.arr0711, out num, out num2);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("奇數共 {0}\n偶數共 {1}", num, num2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000091F4 File Offset: 0x000073F4
		private void button3_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			Myhomework_0711_Method.arrayMaxMin(this.arr0711, out num, out num2);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("最大值為 {0}\n最小值為 {1}", num, num2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009240 File Offset: 0x00007440
		private void button4_Click(object sender, EventArgs e)
		{
			string str;
			Myhomework_0711_Method.arrayStrLongest(this.arr0711_Str, out str);
			this.labelResult.Text = "陣列arr0711_Str [ mother張,emma,迪克蕭,J40]\n最長的名字為" + str;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00009274 File Offset: 0x00007474
		private void button5_Click(object sender, EventArgs e)
		{
			string text = "";
			Myhomework_0711_Method.os1ins0(ref this.grid0711, out text);
			this.labelResult.Text = text;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000092A4 File Offset: 0x000074A4
		private void button6_Click(object sender, EventArgs e)
		{
			string text = "";
			Myhomework_0711_Method.os0ins1(ref this.grid0711, out text);
			this.labelResult.Text = text;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000092D4 File Offset: 0x000074D4
		private void button7_Click(object sender, EventArgs e)
		{
			string text = "";
			Myhomework_0711_Method.o10s10(ref this.grid0711, out text);
			this.labelResult.Text = text;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00009304 File Offset: 0x00007504
		private void button8_Click(object sender, EventArgs e)
		{
			int num = 100;
			int num2 = 200;
			this.labelResult.Text = string.Format("換位前n1={0} , n2={1}", num, num2);
			Myhomework_0711_Method.swaparr(ref num, ref num2);
			Label label = this.labelResult;
			label.Text += string.Format("\n換位後n1={0} , n2={1}", num, num2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00009374 File Offset: 0x00007574
		private void button9_Click(object sender, EventArgs e)
		{
			int num;
			Myhomework_0711_Method.sumarr(this.arr0711, out num);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("加總為 {0}", num);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000093B8 File Offset: 0x000075B8
		private void button10_Click(object sender, EventArgs e)
		{
			int num;
			Myhomework_0711_Method.maxarr(this.arr0711, out num);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("最大值為 {0}", num);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000093FC File Offset: 0x000075FC
		private void button11_Click(object sender, EventArgs e)
		{
			int num;
			Myhomework_0711_Method.minarr(this.arr0711, out num);
			this.labelResult.Text = "int陣列arr0711[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + string.Format("最小值為 {0}", num);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00009440 File Offset: 0x00007640
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

		// Token: 0x04000076 RID: 118
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

		// Token: 0x04000077 RID: 119
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

		// Token: 0x04000078 RID: 120
		private int[,] grid0711 = new int[10, 10];
	}
}
