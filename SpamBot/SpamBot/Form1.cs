using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpamBot
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        string text = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

            timer1.Interval = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
            label1.Text = "Spam meter: " + timer1.Interval + " ms";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 100;
            trackBar1.Value = timer1.Interval;
            label1.Text = "Spam meter: " + timer1.Interval + " ms";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            char random = (char)r.Next('a', 'z');
            text = textBox1.Text + random;
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void End_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
