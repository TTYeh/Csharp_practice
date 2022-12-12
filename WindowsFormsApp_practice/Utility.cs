using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    internal partial class Utility
    {
        internal void method01()
        {
            MessageBox.Show("MyClass Method 1 (internal method)");
        }
        private void method02()
        {
            MessageBox.Show("MyClass Method 2  (privagte method)");
        }
        public void method03()
        {
            MessageBox.Show("MyClass Method 3  (public method)");
        }
        void method04()
        {
            MessageBox.Show("MyClass Method 4  (privagte method)");
        }

        public void method05()
        {
            MessageBox.Show("public method05 call private Method02");
            method02();
        }

    }
    public class InstanceAndStatic
    {
        public int instanceNumber;
        public static int staticNumber;
    }
    public class TestRef
    {
        public int testVal;

    }


}
