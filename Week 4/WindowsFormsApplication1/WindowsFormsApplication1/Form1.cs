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
        private List<ICar> cars;
        public Form1()
        {
            InitializeComponent();
            cars = new List<ICar>();
        }

        private void btnCreateSimpleCar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("You need to fill in the price"); }
            else
            {
                cars.Add(new SimpleCar(Convert.ToInt32(this.textBox1.Text)));
                textBox1.Text = "";
                CleanList();
            }
        }

        private void btnCreateCarWithWTires_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || this.listBox1.SelectedIndex == -1) { MessageBox.Show("You need to fill in the price of tires"); }
            else
            {
                if (cars[listBox1.SelectedIndex] is SimpleCar)
                {
                    cars[this.listBox1.SelectedIndex] = new CarWithWinterTires(cars[listBox1.SelectedIndex], Convert.ToInt32(this.textBox1.Text));
                    textBox1.Text = "";
                    CleanList();
                }
                else
                {
                    MessageBox.Show("This car is already decorated");
                }
            }
        }

        private void btnCreateCarWithConditioner_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || this.listBox1.SelectedIndex == -1) { MessageBox.Show("You need to fill in the price of tires"); }
            else
            {
                if (cars[listBox1.SelectedIndex] is SimpleCar)
                {
                    cars[this.listBox1.SelectedIndex] = new CarWithConditioner(cars[listBox1.SelectedIndex], Convert.ToInt32(this.textBox1.Text));
                    textBox1.Text = "";
                    CleanList();
                }
                else
                {
                    MessageBox.Show("This car is already decorated");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            CleanList();
        }
        private void CleanList()
        {
            this.listBox1.Items.Clear();
            foreach (ICar car in cars)
            {
                this.listBox1.Items.Add(car.GetDescription() + " that costs: " + car.GetPrice());
            }
        }
    }
}
