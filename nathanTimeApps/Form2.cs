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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                NathanFractNumber fract1 = new NathanFractNumber(int.Parse(textBoxFract1Num.Text), int.Parse(textBoxFract1Denom.Text));
                NathanFractNumber fract2 = new NathanFractNumber(int.Parse(textBoxFract2Num.Text), int.Parse(textBoxFract2Denom.Text));

                NathanFractNumber result = fract1.Multiply(fract2);

                listBoxInfo.Items.Add(
                    fract1.Numerator + "/" + fract1.Denomirator + " * " + 
                    fract2.Numerator + "/" + fract2.Denomirator + " = " + 
                    result.Numerator + "/" + result.Denomirator
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
