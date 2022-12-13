using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyHomework
{
    public partial class hw01_Hello : Form
    {
        public hw01_Hello()
        {
            InitializeComponent();
        }


        private void Hello_01_Load(object sender, EventArgs e)
        {
            SetMyButtonIcon(btn_hi);
            SetMyButtonIcon(btn_hello);
        }
        public void SetMyButtonIcon(Button btnRef)
        {
            // Assign an image to the button.
            // TODO  看不懂 https://stackoverflow.com/questions/11483655/icon-inside-of-button
            // https://learn.microsoft.com/zh-tw/dotnet/api/system.drawing.image.fromfile?view=dotnet-plat-ext-7.0
            // 自動調整大小?
            btnRef.BackgroundImageLayout = ImageLayout.Stretch;

            string projectCurPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(
             Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory))));
            // btn_hi.Image = Image.FromFile("C:\\Users\\User\\Desktop\\cSharp_practice\\project\\lab_Csharp_practice\\source\\image_hw\\play.jpg");

            try
            {
                btnRef.Image = Image.FromFile(projectCurPath + "\\source\\image_hw\\play2.png");
                // Align the image and text on the button.
                btnRef.ImageAlign = ContentAlignment.MiddleLeft;
                btnRef.TextAlign = ContentAlignment.MiddleRight;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error opening the bitmap." +
                    "Please check the path.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            String nameChinese = inputName.Text;
            String nameEng = inputEngName.Text;
            String sex = inputSex.Text;
            String star = inputStarsign.Text;
            MessageBox.Show(" Hello, 我是: " + nameChinese + 
                "\n 英文名字是" + nameEng +
                "\n 性別是" + sex +
                "\n 星座是" + star +
                "\n 很高興認識你。");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nameChinese = inputName.Text;
            String nameEng = inputEngName.Text;
            String sex = inputSex.Text;
            String star = inputStarsign.Text;
            MessageBox.Show(" Hi, 我是: " + nameChinese +
                "\n 英文名字是" + nameEng +
                "\n 性別是" + sex +
                "\n 星座是" + star +
                "\n 很高興認識你。");
        }

    }
}
