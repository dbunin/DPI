using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        TVRemote tvRemote;
        RadioRemote radioRemote;
        List<ElectronicDevice> devices;
        List<Command> commands;
        Command lastCommand;
        DeviceButton pressed;
        public Form1()
        {
            InitializeComponent();
            devices = new List<ElectronicDevice>();
            commands = new List<Command>();
            tvRemote = new TVRemote();
            radioRemote = new RadioRemote();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rbRadio.Checked)
            {
                devices.Add(radioRemote.GetDevice());
                lbDevices.Items.Add("Radio");
            }
            else if (rbTV.Checked)
            {
                devices.Add(tvRemote.GetDevice());
                lbDevices.Items.Add("TV");
            }
            else
                MessageBox.Show("You have to select what kind of device you want to add");
        }

        private void btnShowStates_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            if (lbDevices.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select the device");
            }
            else {
                VolumeDown volDown = new VolumeDown(devices[lbDevices.SelectedIndex]);
                pressed = new DeviceButton(volDown);
                lastCommand = volDown;
                pressed.press();
                ShowAll();
            }
            //commands.Add()
        }

        private void btnVolumeUo_Click(object sender, EventArgs e)
        {
            if (lbDevices.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select the device");
            }
            else {
                VolumeUp volUp = new VolumeUp(devices[lbDevices.SelectedIndex]);
                pressed = new DeviceButton(volUp);
                lastCommand = volUp;
                pressed.press();
                ShowAll();
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (lbDevices.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select the device");
            }
            else {
                TurnOff turnOff = new TurnOff(devices[lbDevices.SelectedIndex]);
                pressed = new DeviceButton(turnOff);
                lastCommand = turnOff;
                pressed.press();
                ShowAll();
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (lbDevices.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select the device");
            }
            else {
                TurnOn turnOn = new TurnOn(devices[lbDevices.SelectedIndex]);
                pressed = new DeviceButton(turnOn);
                lastCommand = turnOn;
                pressed.press();
                ShowAll();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lastCommand == null)
            {
                MessageBox.Show("The were no commands performed yet");
            }
            else
            {
                pressed = new DeviceButton(lastCommand);
                pressed.undo();
                ShowAll();
            }
        }
        private void ShowAll()
        {
            lbState.Items.Clear();
            foreach (ElectronicDevice d in devices)
            {
                List<string> temp = d.GetState();
                foreach (string s in temp)
                {
                    lbState.Items.Add(s);
                }
                lbState.Items.Add("");
            }
        }
    }
}
