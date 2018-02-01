using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            float number1 = 0;
            float number2 = 0;

            bool success = float.TryParse(number1TextBox.Text, out number1);
            if (!success)
            {
                MessageBox.Show("number1輸入錯誤");
                return;
            }
            success = float.TryParse(number2TextBox.Text, out number2);
            if (!success)
            {
                MessageBox.Show("number2輸入錯誤");
                return;
            }

            resultTextBox.Text = (number1 + number2).ToString();
        }
    }
}