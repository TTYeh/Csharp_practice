﻿using System;
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

        private void btn_paras_Click(object sender, EventArgs e)
        {
            string totalC = MyParams("國文", 50,60,70,80,90);
            MessageBox.Show(totalC);
            totalC = MyParams("數學");
            MessageBox.Show(totalC);
        }
        string MyParams(string cls, params int[] score)
        {
            int total = 0;
            for (int i = 0; i < score.Length; i++)
            { 
                total += score[i];
            }
            return cls + "總成績: " + total;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            // admin = 1
            // user > 1
            int Role = 1;
            if (Role == 1)
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("管理者可看");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnProduct.Enabled = false;
        }

        private void btnValidConst_Click(object sender, EventArgs e)
        {
            // 不希望被任意修改 >>>常數
            // 但數值又特別多 >>> enum
            int Role = 1;
            const int Admin = 1, user = 2;
            if (Role == Admin)
            {
                btnProduct.Enabled = true;
            }
            else if (Role == user)
            {
                btnProduct.Enabled = false;
            }

        }
    }
}