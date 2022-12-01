using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    internal partial class Utility
    // Point: Partail class要原本的與新增的class在同一個nameSpace下且class名一樣，並加上partial
    {
        public void method06()
        {
            MessageBox.Show("partial class method06");
        }

        public class Member
        // Member是類別，預設定義是internal
        {
            // MName和Age是類別中未指定，預設定義是private
            public string Name;
            public int Age;
        }
    }
}
