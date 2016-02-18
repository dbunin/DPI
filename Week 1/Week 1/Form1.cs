using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1
{
    public partial class Form1 : Form
    {
        List<int> myList = new List<int>();
        List<int> sortedList = new List<int>();
        public Form1()
        {
            InitializeComponent();
            myList.Add(40);
            myList.Add(30);
            myList.Add(80);
            myList.Add(86);
            myList.Add(54);
            myList.Add(27);
            myList.Add(46);
            myList.Add(2);
            myList.Add(99);
            myList.Add(1);
            myList.Add(14);
            myList.Add(72);
            DisplayList();
        }

        void DisplayList()
        {
            foreach(int i in myList)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (rbFirstInFirstOut.Checked)
            {
                for(int i = myList.Count() - 1; i > -1; i++)
                {
                    sortedList.Add(myList[i]);
                }
            }
            else
                if (rbShortestSeekTime.Checked)
                {
                    
                }
                else
                {

                }
        }
    }
}
