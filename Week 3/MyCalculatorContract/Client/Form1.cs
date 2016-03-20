using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using MyCalculatorContract;

namespace Client
{
    public partial class Form1 : Form
    {
        private ServiceReference1.CalculatorClient proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceReference1.CalculatorClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbResult.Text = proxy.Add(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)) + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbResult.Text = proxy.Substract(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)) + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tbResult.Text = proxy.Multiply(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)) + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tbResult.Text = proxy.Divide(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text)) + "";
        }
    }
}
