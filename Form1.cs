using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Tick_counter_Q2
{
    public partial class Form1 : Form
    {
        int ComputerHours, ComputerMinutes, ComputerSeconds;
        int ApplicationHours, ApplicationMinutes, ApplicationSeconds;
        private int CompTime;
        public Form1()        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)        {
        }
        private void button1_Click(object sender, EventArgs e){ this.Close();}
        private void Form1_Load(object sender, EventArgs e){
            CompTime = Environment.TickCount;
            //MessageBox.Show(CompTime.ToString());
            //Clipboard.SetText(CompTime.ToString());
            ComputerSeconds = CompTime / 1000;
            while (ComputerSeconds >= 60)            {
                ComputerMinutes++;
                ComputerSeconds -= 60;
            }
            while (ComputerMinutes >= 60)            {
                ComputerHours++;
                ComputerMinutes -= 60;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)        { 
            ComputerSeconds++;
            while (ComputerSeconds >= 60)            {
                ComputerMinutes++;
                ComputerSeconds -= 60;
            }
            while (ComputerMinutes >= 60)            {
                ComputerHours++;
                ComputerMinutes -= 60;
            }
            label1.Text = String.Format("This computer has been ON for {0} hours, {1} minutes {2} seconds",
                              ComputerHours.ToString(),
                              ComputerMinutes.ToString(),
                              ComputerSeconds.ToString());

            ApplicationSeconds++;
            while (ApplicationSeconds >= 60)            {
                ApplicationMinutes++;
                ApplicationSeconds -= 60;
            }
            while (ApplicationMinutes >= 60)            {
                ApplicationHours++;
                ApplicationMinutes -= 60;
            }
            label2.Text = String.Format("This application has been running for {0} hours, {1} minutes {2} seconds",
                              ApplicationHours.ToString(),
                              ApplicationMinutes.ToString(),
                              ApplicationSeconds.ToString());
        }
    }
}
