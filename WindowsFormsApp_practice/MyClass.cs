using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    internal class MyClass
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
    }
}
