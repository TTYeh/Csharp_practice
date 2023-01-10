namespace MyHomework_張佑晨0708
{
	// Token: 0x02000015 RID: 21
	public partial class Myhomework_0718_Notepad : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x000128B0 File Offset: 0x00010AB0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000128E8 File Offset: 0x00010AE8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MyHomework_張佑晨0708.Myhomework_0718_Notepad));
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.檔案FToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.新增NToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.開啟OToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new global::System.Windows.Forms.ToolStripSeparator();
			this.儲存SToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.另存新檔AToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.列印PToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.預覽列印VToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.結束XToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.編輯EToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.復原UToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.取消復原RToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.剪下TToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.複製CToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.貼上PToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.全選AToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.工具TToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.自訂CToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.選項OToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.格式ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.顏色CToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.字型VToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toUpperUToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toLowerLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.自動換行ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.快選顏色ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.blackToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.說明HToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.內容CToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.索引IToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.搜尋SToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.關於AToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.新增NToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.開啟OToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.儲存SToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.列印PToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.剪下UToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.複製CToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.貼上PToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.說明LToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.fontDialog1 = new global::System.Windows.Forms.FontDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.檔案FToolStripMenuItem,
				this.編輯EToolStripMenuItem,
				this.工具TToolStripMenuItem,
				this.格式ToolStripMenuItem,
				this.說明HToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(800, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.檔案FToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.新增NToolStripMenuItem,
				this.開啟OToolStripMenuItem,
				this.toolStripSeparator,
				this.儲存SToolStripMenuItem,
				this.另存新檔AToolStripMenuItem,
				this.toolStripSeparator1,
				this.列印PToolStripMenuItem,
				this.預覽列印VToolStripMenuItem,
				this.toolStripSeparator2,
				this.結束XToolStripMenuItem
			});
			this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
			this.檔案FToolStripMenuItem.Size = new global::System.Drawing.Size(69, 23);
			this.檔案FToolStripMenuItem.Text = "檔案(&F)";
			this.新增NToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("新增NToolStripMenuItem.Image");
			this.新增NToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
			this.新增NToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131150;
			this.新增NToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.新增NToolStripMenuItem.Text = "新增(&N)";
			this.新增NToolStripMenuItem.Click += new global::System.EventHandler(this.新增NToolStripMenuItem_Click);
			this.開啟OToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("開啟OToolStripMenuItem.Image");
			this.開啟OToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
			this.開啟OToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131151;
			this.開啟OToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.開啟OToolStripMenuItem.Text = "開啟(&O)";
			this.開啟OToolStripMenuItem.Click += new global::System.EventHandler(this.開啟OToolStripMenuItem_Click);
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new global::System.Drawing.Size(190, 6);
			this.儲存SToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("儲存SToolStripMenuItem.Image");
			this.儲存SToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
			this.儲存SToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
			this.儲存SToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.儲存SToolStripMenuItem.Text = "儲存(&S)";
			this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
			this.另存新檔AToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.另存新檔AToolStripMenuItem.Text = "另存新檔(&A)";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(190, 6);
			this.列印PToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("列印PToolStripMenuItem.Image");
			this.列印PToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
			this.列印PToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131152;
			this.列印PToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.列印PToolStripMenuItem.Text = "列印(&P)";
			this.預覽列印VToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("預覽列印VToolStripMenuItem.Image");
			this.預覽列印VToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.預覽列印VToolStripMenuItem.Name = "預覽列印VToolStripMenuItem";
			this.預覽列印VToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.預覽列印VToolStripMenuItem.Text = "預覽列印(&V)";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(190, 6);
			this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
			this.結束XToolStripMenuItem.Size = new global::System.Drawing.Size(193, 26);
			this.結束XToolStripMenuItem.Text = "結束(&X)";
			this.結束XToolStripMenuItem.Click += new global::System.EventHandler(this.結束XToolStripMenuItem_Click);
			this.編輯EToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.復原UToolStripMenuItem,
				this.取消復原RToolStripMenuItem,
				this.toolStripSeparator3,
				this.剪下TToolStripMenuItem,
				this.複製CToolStripMenuItem,
				this.貼上PToolStripMenuItem,
				this.toolStripSeparator4,
				this.全選AToolStripMenuItem
			});
			this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
			this.編輯EToolStripMenuItem.Size = new global::System.Drawing.Size(69, 23);
			this.編輯EToolStripMenuItem.Text = "編輯(&E)";
			this.復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
			this.復原UToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131162;
			this.復原UToolStripMenuItem.Size = new global::System.Drawing.Size(218, 26);
			this.復原UToolStripMenuItem.Text = "復原(&U)";
			this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
			this.取消復原RToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131161;
			this.取消復原RToolStripMenuItem.Size = new global::System.Drawing.Size(218, 26);
			this.取消復原RToolStripMenuItem.Text = "取消復原(&R)";
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(215, 6);
			this.剪下TToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("剪下TToolStripMenuItem.Image");
			this.剪下TToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
			this.剪下TToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131160;
			this.剪下TToolStripMenuItem.Size = new global::System.Drawing.Size(218, 26);
			this.剪下TToolStripMenuItem.Text = "剪下(&T)";
			this.剪下TToolStripMenuItem.Click += new global::System.EventHandler(this.剪下TToolStripMenuItem_Click);
			this.複製CToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("複製CToolStripMenuItem.Image");
			this.複製CToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
			this.複製CToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
			this.複製CToolStripMenuItem.Size = new global::System.Drawing.Size(218, 26);
			this.複製CToolStripMenuItem.Text = "複製(&C)";
			this.複製CToolStripMenuItem.Click += new global::System.EventHandler(this.複製CToolStripMenuItem_Click);
			this.貼上PToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("貼上PToolStripMenuItem.Image");
			this.貼上PToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
			this.貼上PToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131158;
			this.貼上PToolStripMenuItem.Size = new global::System.Drawing.Size(218, 26);
			this.貼上PToolStripMenuItem.Text = "貼上(&P)";
			this.貼上PToolStripMenuItem.Click += new global::System.EventHandler(this.貼上PToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(215, 6);
			this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
			this.全選AToolStripMenuItem.Size = new global::System.Drawing.Size(218, 26);
			this.全選AToolStripMenuItem.Text = "全選(&A)";
			this.全選AToolStripMenuItem.Click += new global::System.EventHandler(this.全選AToolStripMenuItem_Click);
			this.工具TToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.自訂CToolStripMenuItem,
				this.選項OToolStripMenuItem
			});
			this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
			this.工具TToolStripMenuItem.Size = new global::System.Drawing.Size(69, 23);
			this.工具TToolStripMenuItem.Text = "工具(&T)";
			this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
			this.自訂CToolStripMenuItem.Size = new global::System.Drawing.Size(136, 26);
			this.自訂CToolStripMenuItem.Text = "自訂(&C)";
			this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
			this.選項OToolStripMenuItem.Size = new global::System.Drawing.Size(136, 26);
			this.選項OToolStripMenuItem.Text = "選項(&O)";
			this.格式ToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.顏色CToolStripMenuItem,
				this.字型VToolStripMenuItem,
				this.toUpperUToolStripMenuItem,
				this.toLowerLToolStripMenuItem,
				this.自動換行ToolStripMenuItem,
				this.快選顏色ToolStripMenuItem
			});
			this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
			this.格式ToolStripMenuItem.Size = new global::System.Drawing.Size(75, 23);
			this.格式ToolStripMenuItem.Text = "格式(&M)";
			this.顏色CToolStripMenuItem.Name = "顏色CToolStripMenuItem";
			this.顏色CToolStripMenuItem.Size = new global::System.Drawing.Size(169, 26);
			this.顏色CToolStripMenuItem.Text = "顏色(&C)...";
			this.顏色CToolStripMenuItem.Click += new global::System.EventHandler(this.顏色CToolStripMenuItem_Click);
			this.字型VToolStripMenuItem.Name = "字型VToolStripMenuItem";
			this.字型VToolStripMenuItem.Size = new global::System.Drawing.Size(169, 26);
			this.字型VToolStripMenuItem.Text = "字型(&V)...";
			this.字型VToolStripMenuItem.Click += new global::System.EventHandler(this.字型VToolStripMenuItem_Click);
			this.toUpperUToolStripMenuItem.Name = "toUpperUToolStripMenuItem";
			this.toUpperUToolStripMenuItem.Size = new global::System.Drawing.Size(169, 26);
			this.toUpperUToolStripMenuItem.Text = "To Upper(&U)";
			this.toUpperUToolStripMenuItem.Click += new global::System.EventHandler(this.toUpperUToolStripMenuItem_Click);
			this.toLowerLToolStripMenuItem.Name = "toLowerLToolStripMenuItem";
			this.toLowerLToolStripMenuItem.Size = new global::System.Drawing.Size(169, 26);
			this.toLowerLToolStripMenuItem.Text = "To Lower(&L)";
			this.toLowerLToolStripMenuItem.Click += new global::System.EventHandler(this.toLowerLToolStripMenuItem_Click);
			this.自動換行ToolStripMenuItem.Name = "自動換行ToolStripMenuItem";
			this.自動換行ToolStripMenuItem.Size = new global::System.Drawing.Size(169, 26);
			this.自動換行ToolStripMenuItem.Text = "自動換行";
			this.自動換行ToolStripMenuItem.Click += new global::System.EventHandler(this.自動換行ToolStripMenuItem_Click);
			this.快選顏色ToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.redToolStripMenuItem,
				this.greenToolStripMenuItem,
				this.blueToolStripMenuItem,
				this.blackToolStripMenuItem
			});
			this.快選顏色ToolStripMenuItem.Name = "快選顏色ToolStripMenuItem";
			this.快選顏色ToolStripMenuItem.Size = new global::System.Drawing.Size(169, 26);
			this.快選顏色ToolStripMenuItem.Text = "快選顏色";
			this.redToolStripMenuItem.Name = "redToolStripMenuItem";
			this.redToolStripMenuItem.Size = new global::System.Drawing.Size(126, 26);
			this.redToolStripMenuItem.Text = "Red";
			this.redToolStripMenuItem.Click += new global::System.EventHandler(this.redToolStripMenuItem_Click);
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new global::System.Drawing.Size(126, 26);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new global::System.EventHandler(this.greenToolStripMenuItem_Click);
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new global::System.Drawing.Size(126, 26);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new global::System.EventHandler(this.blueToolStripMenuItem_Click);
			this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
			this.blackToolStripMenuItem.Size = new global::System.Drawing.Size(126, 26);
			this.blackToolStripMenuItem.Text = "Black";
			this.blackToolStripMenuItem.Click += new global::System.EventHandler(this.blackToolStripMenuItem_Click);
			this.說明HToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.內容CToolStripMenuItem,
				this.索引IToolStripMenuItem,
				this.搜尋SToolStripMenuItem,
				this.toolStripSeparator5,
				this.關於AToolStripMenuItem
			});
			this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
			this.說明HToolStripMenuItem.Size = new global::System.Drawing.Size(72, 23);
			this.說明HToolStripMenuItem.Text = "說明(&H)";
			this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
			this.內容CToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.內容CToolStripMenuItem.Text = "內容(&C)";
			this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
			this.索引IToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.索引IToolStripMenuItem.Text = "索引(&I)";
			this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
			this.搜尋SToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.搜尋SToolStripMenuItem.Text = "搜尋(&S)";
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(140, 6);
			this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
			this.關於AToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.關於AToolStripMenuItem.Text = "關於(&A)...";
			this.關於AToolStripMenuItem.Click += new global::System.EventHandler(this.關於AToolStripMenuItem_Click);
			this.toolStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.新增NToolStripButton,
				this.開啟OToolStripButton,
				this.儲存SToolStripButton,
				this.列印PToolStripButton,
				this.toolStripSeparator6,
				this.剪下UToolStripButton,
				this.複製CToolStripButton,
				this.貼上PToolStripButton,
				this.toolStripSeparator7,
				this.說明LToolStripButton
			});
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 27);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new global::System.Drawing.Size(800, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.新增NToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.新增NToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("新增NToolStripButton.Image");
			this.新增NToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.新增NToolStripButton.Name = "新增NToolStripButton";
			this.新增NToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.新增NToolStripButton.Text = "新增(&N)";
			this.新增NToolStripButton.Click += new global::System.EventHandler(this.新增NToolStripButton_Click);
			this.開啟OToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.開啟OToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("開啟OToolStripButton.Image");
			this.開啟OToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.開啟OToolStripButton.Name = "開啟OToolStripButton";
			this.開啟OToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.開啟OToolStripButton.Text = "開啟(&O)";
			this.開啟OToolStripButton.Click += new global::System.EventHandler(this.開啟OToolStripButton_Click);
			this.儲存SToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.儲存SToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("儲存SToolStripButton.Image");
			this.儲存SToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.儲存SToolStripButton.Name = "儲存SToolStripButton";
			this.儲存SToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.儲存SToolStripButton.Text = "儲存(&S)";
			this.列印PToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.列印PToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("列印PToolStripButton.Image");
			this.列印PToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.列印PToolStripButton.Name = "列印PToolStripButton";
			this.列印PToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.列印PToolStripButton.Text = "列印(&P)";
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(6, 27);
			this.剪下UToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.剪下UToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("剪下UToolStripButton.Image");
			this.剪下UToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.剪下UToolStripButton.Name = "剪下UToolStripButton";
			this.剪下UToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.剪下UToolStripButton.Text = "剪下(&U)";
			this.剪下UToolStripButton.Click += new global::System.EventHandler(this.剪下UToolStripButton_Click);
			this.複製CToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.複製CToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("複製CToolStripButton.Image");
			this.複製CToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.複製CToolStripButton.Name = "複製CToolStripButton";
			this.複製CToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.複製CToolStripButton.Text = "複製(&C)";
			this.複製CToolStripButton.Click += new global::System.EventHandler(this.複製CToolStripButton_Click);
			this.貼上PToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.貼上PToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("貼上PToolStripButton.Image");
			this.貼上PToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.貼上PToolStripButton.Name = "貼上PToolStripButton";
			this.貼上PToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.貼上PToolStripButton.Text = "貼上(&P)";
			this.貼上PToolStripButton.Click += new global::System.EventHandler(this.貼上PToolStripButton_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(6, 27);
			this.說明LToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.說明LToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("說明LToolStripButton.Image");
			this.說明LToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.說明LToolStripButton.Name = "說明LToolStripButton";
			this.說明LToolStripButton.Size = new global::System.Drawing.Size(24, 24);
			this.說明LToolStripButton.Text = "說明(&L)";
			this.說明LToolStripButton.Click += new global::System.EventHandler(this.說明LToolStripButton_Click);
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 426);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(800, 24);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(158, 19);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new global::System.Drawing.Point(0, 54);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new global::System.Drawing.Size(800, 372);
			this.textBox1.TabIndex = 3;
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.toolStrip1);
			base.Controls.Add(this.menuStrip1);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "Myhomework_0718_Notepad";
			this.Text = "Myhomework_0718_Notepad";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000128 RID: 296
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.ToolStripMenuItem 列印PToolStripMenuItem;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.ToolStripMenuItem 預覽列印VToolStripMenuItem;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.ToolStripMenuItem 復原UToolStripMenuItem;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.ToolStripButton 新增NToolStripButton;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.ToolStripButton 開啟OToolStripButton;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.ToolStripButton 儲存SToolStripButton;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.ToolStripButton 列印PToolStripButton;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.ToolStripButton 剪下UToolStripButton;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.ToolStripButton 複製CToolStripButton;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.ToolStripButton 貼上PToolStripButton;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.ToolStripButton 說明LToolStripButton;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.ToolStripMenuItem 顏色CToolStripMenuItem;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.ToolStripMenuItem 字型VToolStripMenuItem;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.FontDialog fontDialog1;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.ToolStripMenuItem toUpperUToolStripMenuItem;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.ToolStripMenuItem toLowerLToolStripMenuItem;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.ToolStripMenuItem 自動換行ToolStripMenuItem;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.ToolStripMenuItem 快選顏色ToolStripMenuItem;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
	}
}
