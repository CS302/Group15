#define TRIAL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowProgInfo();
            double x = Sum(10, 15);
        }

        [Conditional("DEBUG")]
        private void ShowProgInfo()
        {
            MessageBox.Show("Приложение калькулятор\nv1.0.1");
        }

        [Obsolete("Новый метод Sum(double, double)", false)]
        private int Sum(int x, int y)
        {
            return x + y;
        }

        private double Sum(double x, double y)
        {
            return x + y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if TRIAL
            Random rnd = new Random();
            richTextBox3.Text = rnd.Next(6515156).ToString();
            MessageBox.Show("Купите полную версию");
#else
//#warning Не дописал проверку
//#error Не дописал проверку
            richTextBox3.Text = (int.Parse(richTextBox1.Text) + int.Parse(richTextBox2.Text)).ToString();
#endif
        }
    }
}
