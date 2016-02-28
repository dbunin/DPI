using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2ObserverPatern
{
    public partial class Form2 : Form, ISubscriber
    {
        List<string> news;
        public Form2()
        {
            InitializeComponent();
            news = new List<string>();
        }
        public void Update(Subject a)
        {
            news = a.GetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = news[Convert.ToInt32(textBox1.Text)-1];
            }
            catch
            {
                MessageBox.Show("Your input is wrong");
            }
        }
    }
}
