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
        int nextNumber;
        Dictionary<int, Label> dic = new Dictionary<int, Label>();
        List<int> myList = new List<int>();
        int currentNumber;
        ShortestSeekTime ssta = new ShortestSeekTime();
        FirstInFirstOut fifo = new FirstInFirstOut();
        Elevetor elevetor = new Elevetor();

        public Form1()
        {
            InitializeComponent();
            myList.Add(40);
            currentNumber = 40;
            trackBar1.Value = currentNumber;
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
            DisplayLables();
        }
        void DisplayLables()
        {
            foreach(int i in myList)
            {
                Label lb = new Label();
                lb.Location = new Point(25, 25);
                lb.Size = new Size(30, 30);
                lb.Text = i.ToString();
                lb.Visible = true;
                dic.Add(i, lb);
                Controls.Add(lb);
            }
        }
        void DisplayList()
        {
            listBox1.Items.Clear();
            textBox1.Text = nextNumber.ToString();
            foreach(int i in myList)
            {
                listBox1.Items.Add(i);
            }
        }
        void FindNextNumber()
        {
            if (rbFirstInFirstOut.Checked)
                nextNumber = fifo.FindNext(myList, currentNumber);
            else
                if (rbShortestSeekTime.Checked)
                    nextNumber = ssta.FindNext(myList, currentNumber);
                else
                    if (rbSCANDisc.Checked)
                        nextNumber = elevetor.FindNext(myList, currentNumber);
        }
        void RemoveNextAndCurrent()
        {
            myList.Remove(nextNumber);
            myList.Remove(currentNumber);
            currentNumber = nextNumber;
            FindNextNumber();
            DisplayList();
        }
        void RemoveNumber(int numberToCheck)
        {
            if (rbFirstInFirstOut.Checked && fifo.Remove(myList, numberToCheck, nextNumber) == 1)
                RemoveNextAndCurrent();
            else
                if (rbSCANDisc.Checked)
                {
                    if (elevetor.Remove(myList, numberToCheck, nextNumber) == 1)
                    {
                        RemoveNextAndCurrent();
                    }
                    else
                        if (elevetor.Remove(myList, numberToCheck, nextNumber) == 2)
                        {
                            myList.Remove(numberToCheck);
                            DisplayList();
                        }
                }
                else
                    if (rbShortestSeekTime.Checked && ssta.Remove(myList, numberToCheck, nextNumber) == 1)
                        RemoveNextAndCurrent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            FindNextNumber();
            myList.Remove(currentNumber);
            DisplayList();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(trackBar1.Value - nextNumber > 0)
            {
                trackBar1.Value -= 1;
            }
            else
            {
                trackBar1.Value += 1;
            }
            RemoveNumber(trackBar1.Value);
        }

        private void rbFirstInFirstOut_CheckedChanged(object sender, EventArgs e)
        {
            if(button1.Enabled == false)
                FindNextNumber();
        }

        private void rbShortestSeekTime_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
                FindNextNumber();
        }

        private void rbSCANDisc_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
                FindNextNumber();
        }
    }
}
