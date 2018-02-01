using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = number1TextBox.Text + number2TextBox.Text;
        }

        private void execAddButton_Click(object sender, EventArgs e)
        {
            int number1 = 0;  //給預設值是0,沒有輸入值時,不會當
            bool success = int.TryParse(number1TextBox.Text, out number1);
            if (!success)
            {
                MessageBox.Show("number1輸入錯誤");
                return;       //中斷執行
            }
            int number2 = 0;  //給預設值是0
            success = int.TryParse(number2TextBox.Text, out number2);
            if (!success)
            {
                MessageBox.Show("number2輸入錯誤");
                return;
            }
            resultTextBox.Text = (number1 + number2).ToString();
        }
    }
}