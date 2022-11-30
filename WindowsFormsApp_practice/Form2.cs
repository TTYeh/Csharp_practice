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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openHelloForm_Click(object sender, EventArgs e)
        {
            // 重點:程式進入點 Application.Run(在program.cs)要設定為form2  當作是主程式
            Form1 myHelloForm = new Form1();
            myHelloForm.Show();
        }

        private void method_area_Click(object sender, EventArgs e)
        {
            FirstMethod();
        }

        void FirstMethod()
        {
            // void沒有回傳值
            string userName = "jack";
            MessageBox.Show("我是"+ userName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void returnMethod_Click(object sender, EventArgs e)
        {
            string birthYear = ReturnBirthYear(20);
            MessageBox.Show(birthYear);
        }

        string ReturnBirthYear(int age)
        {
            int birthYear = DateTime.Now.Year - age;
            string result = "出生年" + birthYear;
            return result;
        }
    }
}
