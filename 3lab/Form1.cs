using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var n1 = Convert.ToInt32(textBox1.Text);
            var n2 = Convert.ToInt32(textBox2.Text);
            var a1 = new Mebli[n1];
            var a2 = new Mebli[n2];

            double sum = 0, num = 1;
            int i2 = 0;
            
            for (int i = 50; i < n1+50; i++)
            {
                a1[i2] = new Shafa(i, "Шафа");
                listBox1.Items.Add(a1[i2].GetNazva() + " #" + num + ": " + a1[i2].CCost());
                sum = sum + a1[i2].CCost();
                num++;
                i2++;
            }

            listBox1.Items.Add("Середня ціна шаф: " + sum/n1);

            listBox1.Items.Add("");

            num = 1;
            sum = 0;
            i2 = 0;

            for (int i = 150; i < n2 + 150; i++)
            {
                a2[i2] = new Divan(i, "Диван");
                listBox1.Items.Add(a2[i2].GetNazva() + " #" + num + ": " + a2[i2].CCost());
                sum = sum + a2[i2].CCost();
                num++;
            }

            listBox1.Items.Add("Середня ціна диванів: " + sum / n2);

        }
    }
}
