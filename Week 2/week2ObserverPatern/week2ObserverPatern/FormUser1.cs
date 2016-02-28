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
    public partial class FormUser1 : Form, ISubscriber
    {
        List<string> myList;
        public FormUser1()
        {
            InitializeComponent();
            myList = new List<string>();
        }
        public void Update(Subject a)
        {
            listBox1.Items.Clear();
            foreach(string s in a.GetText())
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
