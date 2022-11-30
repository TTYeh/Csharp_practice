using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    internal partial class MyClass
    // Point: Partail class要原本的與新增的class在同一個nameSpace下且class名一樣，並加上partial
    {
        public void method06()
        {
            MessageBox.Show("partial class method06");
        }

        class MemberDemo
        // Member是internal
        {
            // Name和Age是private
            string Name;
            int Age;
        }
        public class Member
        {
            public string Name;
            public int Age;
        }
    }
}
