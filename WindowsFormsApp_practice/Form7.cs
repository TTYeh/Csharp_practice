using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // 定義變數: 傳統的集合
        ArrayList isEmp = new ArrayList();
        public struct Employee
        {
            public string Name;
            public int Age;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtBox_name.Text;
            emp.Age = int.Parse(txtBoxAge.Text);

            // 傳統的集合
            isEmp.Add(emp); // 把emp轉成 object (Boxing動作)
            showMethod();
        }
        void showMethod() 
        {
            labShowEmp.Text = "-----員工清單-----\n";
            for (int i = 0; i < isEmp.Count; i++)
            {
                // 錯誤: (Boxing動作)後沒有unboxing先轉成struct
                // labShowEmp.Text += $"姓名: {isEmp[i].Name} , 年齡: {isEmp[i].Name} \n";
                Employee employee = (Employee)isEmp[i];
                labShowEmp.Text += $"姓名: {employee.Name} , 年齡: {employee.Age} \n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtBox_name.Text;
            emp.Age = int.Parse(txtBoxAge.Text);
            isEmp.Insert(0, emp);
            showMethod();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            isEmp.RemoveAt(0);
            showMethod();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            isEmp.Clear();
            showMethod();
        }
    }

}
