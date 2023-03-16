using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nathanTimeApps
{
    public partial class Form1 : Form
    {
        NathanTime myTime = new NathanTime();
        NathanTime myTime2;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayTime(Label labelH, Label labelM, Label labelS, Label labelTotalSec)
        {
            labelH.Text = myTime.Hour.ToString();
            labelM.Text = myTime.Minute.ToString();
            labelS.Text = myTime.Second.ToString();
            labelTotalSec.Text = myTime.ConvertToSecond().ToString();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonAddTimeWithSeconds.Checked)
                {
                    bool secAddStatus = int.TryParse(textBoxSecond.Text, out int result);
                    if (secAddStatus)
                    {
                        int secAdd = result;
                        myTime.AddSecond(secAdd);
                        DisplayTime(labelHour, labelMinute, labelSecond, labelTotalSecond);
                    }
                    else
                    {
                        MessageBox.Show("Please enter the number correctly!");
                    }
                }
                else if (radioButtonSetCurrentTime.Checked)
                {
                    int h = (int)numericUpDownHour.Value;
                    int m = (int)numericUpDownMinute.Value;
                    int s = (int)numericUpDownSecond.Value;

                    myTime.SetTime(h, m, s);
                    DisplayTime(labelHour, labelMinute, labelSecond, labelTotalSecond);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            labelHour.Text = "";
            labelMinute.Text = "";
            labelSecond.Text = "";
            labelTotalSecond.Text = "";
            numericUpDownHour.Value = 0;
            numericUpDownMinute.Value = 0;
            numericUpDownSecond.Value = 0;
            textBoxSecond.Clear();
            myTime.SetTime(0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelHour.Text = myTime.Hour.ToString();
            labelMinute.Text = myTime.Minute.ToString();
            labelSecond.Text = myTime.Second.ToString();
            labelTotalSecond.Text = myTime.ConvertToSecond().ToString();

            myTime2 = new NathanTime(10, 3, 3);
            MessageBox.Show("This second time: " + 
                myTime2.Hour.ToString() + ":" + 
                myTime2.Minute.ToString() + ":" + 
                myTime2.Second.ToString()
            );
        }

        private void TimerTick(object sender, EventArgs e)
        {
            myTime.AddSecond(1);
            DisplayTime(labelHour, labelMinute, labelSecond, labelTotalSecond);
        }
    }
}
