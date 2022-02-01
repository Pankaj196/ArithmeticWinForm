using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArithClass;
namespace ArithmeticWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(textBox1.Text);
            int y=Convert.ToInt32(textBox2.Text);
            Class1 c=new Class1();
            textBox3.Text=Convert.ToString(c.Addtion(x,y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            Class1 c = new Class1();
            textBox3.Text = Convert.ToString(c.Sub(x, y));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            Class1 c = new Class1();
            textBox3.Text = Convert.ToString(c.Mul(x, y));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            Class1 c = new Class1();
            textBox3.Text = Convert.ToString(c.Div(x, y));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                progressBar1.Value = 0;
                timer1.Stop();

            }
        }
    }
}
