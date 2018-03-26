using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            count = count + 1;
            label1.Text =  count.ToString();
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            this.Size = new Size(330, 400);
            timer1.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string[] arr = str.Split(' ');
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != 1)
                {
                    char ch1 = arr[i][0];
                    char ch2 = arr[i][arr[i].Length - 1];
                    arr[i] = ch2 + arr[i].Substring(1, arr[i].Length - 2) + ch1;
                }
                result += arr[i] + " ";
            }
            textBox1.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (label2.Left < this.Width)
                { label2.Left += 2; }
                else
                { label2.Left = -label2.Width; }
            }
        }
    }
}

