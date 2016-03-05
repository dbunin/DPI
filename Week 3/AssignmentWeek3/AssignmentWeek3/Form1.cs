using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentWeek3
{
    public partial class Form1 : Form
    {
        List<Dealer> dealers;
        public Form1()
        {
            InitializeComponent();
            dealers = new List<Dealer>();
        }

        private void btnCreateDealer_Click(object sender, EventArgs e)
        {
            if (!(tb.Text == null))
            {
                if (GetDealerFromName(tb.Text) == null)
                    dealers.Add(new Dealer(new AudiFactory(), tb.Text));
                else
                    MessageBox.Show("Dealer with such name already exsit");
            }
            else
                MessageBox.Show("You need to write the name of the dealer in text box");
        }

        private void btnCreateDealerBMW_Click(object sender, EventArgs e)
        {
            if (!(tb.Text == null))
            {
                if (GetDealerFromName(tb.Text) == null)
                    dealers.Add(new Dealer(new BMWFactory(), tb.Text));
                else
                    MessageBox.Show("Dealer with such name already exsit");
            }
            else
                MessageBox.Show("You need to write the name of the dealer in text box");
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            if (!(tb.Text == null))
            {
                Dealer d = GetDealerFromName(tb.Text);
                if (d != null)
                {
                    d.CreateCarOfTypeEconom();
                }
                else
                    MessageBox.Show("Dealer with such name doesn't exist");
            }
            else
                MessageBox.Show("You need to write the name of the dealer in text box");
        }

        private void btnGetCarsFromDealer_Click(object sender, EventArgs e)
        {
            if (!(tb.Text == null))
            {
                Dealer d = GetDealerFromName(tb.Text);
                if (d != null)
                {
                    lb.Items.Clear();
                    foreach(string s in d.GetAllCarsCreatedByFactory())
                    {
                        lb.Items.Add(s);
                    }
                }
                else
                    MessageBox.Show("Dealer with such name doesn't exist");
            }
            else
                MessageBox.Show("You need to write the name of the dealer in text box");
        }

        private void btnGetAllCars_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            foreach (Dealer d in dealers)
            {
                lb.Items.Add("Dealer: " + d.GetName());
                foreach (string s in d.GetAllCarsCreatedByFactory())
                {
                    lb.Items.Add(s);
                }
            }
        }

        private void btnCreateSportCar_Click(object sender, EventArgs e)
        {
            if (!(tb.Text == null))
            {
                Dealer d = GetDealerFromName(tb.Text);
                if (d != null)
                {
                    d.CreateCarOfTypeSport();
                }
                else
                    MessageBox.Show("Dealer with such name doesn't exist");
            }
            else
                MessageBox.Show("You need to write the name of the dealer in text box");
        }
        public Dealer GetDealerFromName(string name)
        {
            foreach (Dealer d in dealers)
            {
                if (d.GetName() == name)
                    return d;
            }
            return null;
        }
    }
}
