using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string show = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void bclick(object sender, EventArgs e)
        {
            label1.Text="点击了";
            //textBox1.Text = "确实点击了";
            user.name = textBox1.Text;
            Form input = new inputform();
            input.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("我是提示框");
                     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
