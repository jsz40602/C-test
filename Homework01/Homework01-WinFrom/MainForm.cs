using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework01_WinFrom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button001_Click(object sender, EventArgs e)
        {
            Form001 Form1 = new Form001();
            Form1.Show();
        }

        private void Button004_Click(object sender, EventArgs e)
        {
            Form004 Form4 = new Form004();
            Form4.Show();
        }

        private void Button007_Click(object sender, EventArgs e)
        {
            Form007 Form7 = new Form007();
            Form7.Show();
        }
    }
}