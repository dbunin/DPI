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
    public partial class Form1 : Form
    {
        Subject s;
        public Form1()
        {
            InitializeComponent();
            s = new Subject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.AddNews(textBox1.Text);
            s.Notify();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISubscriber feed = new FormUser1();
            s.Subscribe(feed);
            ((Form)feed).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ISubscriber feed = new Form2();
            s.Subscribe(feed);
            ((Form)feed).Show();
        }
    }
}
