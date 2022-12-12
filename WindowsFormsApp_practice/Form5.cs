using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_callVal_Click(object sender, EventArgs e)
        {
            TestRef tf = new TestRef();
            tf.testVal = 100;
            MessageBox.Show("test Val: "+ tf.testVal);

            functionRef(tf);
            MessageBox.Show("test Val: " + tf.testVal);
        }
        void functionRef(TestRef testVal) 
        {
            testVal.testVal = 300;
        }
        void functionRef2(ref int testVal)
        {
            testVal = 3001;
        }
        void functionRef3(out int testVal)
        {
            testVal = 20;
        }
        private void btn_ref22_Click(object sender, EventArgs e)
        {
            int testVal = 100;
            MessageBox.Show("test Val: " + testVal);

            functionRef2(ref testVal);
            MessageBox.Show("test Val: " + testVal);
        }

        private void btn_refOut_Click(object sender, EventArgs e)
        {
            int testVal = 100;
            MessageBox.Show("test Val: " + testVal);

            functionRef3(out testVal);
            MessageBox.Show("test Val: " + testVal);
        }
    }
}
