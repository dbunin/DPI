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
        List<IVisitable> products = new List<IVisitable>();
        HolidayTaxVisitor holidayTax = new HolidayTaxVisitor();
        TaxVisitor normalTax = new TaxVisitor();
        double sum = 0;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                listBox1.Items.Clear();
                products.Clear();
                sum = 0;
                flag = false;
            }
            //buy tobacco
            Tobacco t = new Tobacco(Convert.ToDouble(this.tbPrice.Text));
            products.Add(t);
            listBox1.Items.Add("Tobacco price: " + t.getPrice());
            if (rbHoliday.Checked)
            {
                listBox1.Items.Add("Price with tax: " + holidayTax.visit(t).ToString("C"));
                sum += holidayTax.visit(t);
            }
            else
            {
                listBox1.Items.Add("Price with tax: " + normalTax.visit(t).ToString("C"));
                sum += holidayTax.visit(t);
            }
            listBox1.Items.Add(" ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                listBox1.Items.Clear();
                products.Clear();
                sum = 0;
                flag = false;
            }
            //buy liquor
            Liquor t = new Liquor(Convert.ToDouble(this.tbPrice.Text));
            products.Add(t);
            listBox1.Items.Add("Liquor price: " + t.getPrice());
            if (rbHoliday.Checked)
            {
                listBox1.Items.Add("Price with tax: " + holidayTax.visit(t).ToString("C"));
                sum += holidayTax.visit(t);
            }
            else
            {
                listBox1.Items.Add("Price with tax: " + normalTax.visit(t).ToString("C"));
                sum += holidayTax.visit(t);
            }
            listBox1.Items.Add(" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Total price is: " + sum.ToString("C"));
            flag = true;
        }
    }
}
