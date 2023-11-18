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

            double sum = 0, num = 1;
            
            for (int i = 50; i < n1+50; i++)
            {
                var shafa = new Shafa(i, "Шафа");
                listBox1.Items.Add(shafa.GetNazva() + " #" + num + ": " + shafa.CCost());
                sum = sum + shafa.CCost();
                num++;
            }

            listBox1.Items.Add("Середня ціна шаф: " + sum/n1);

            listBox1.Items.Add("");

            num = 1;
            sum = 0;

            for (int i = 150; i < n2 + 150; i++)
            {
                var divan = new Divan(i, "Диван");
                listBox1.Items.Add(divan.GetNazva() + " #" + num + ": " + divan.CCost());
                sum = sum + divan.CCost();
                num++;
            }

            listBox1.Items.Add("Середня ціна диванів: " + sum / n2);

        }
    }
}
