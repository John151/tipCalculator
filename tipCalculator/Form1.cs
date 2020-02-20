using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool txtBillAmtValid = Double.TryParse(txtBillAmt.Text, out double billAmt);
            bool txtNumPeopleValid = Int32.TryParse(txtNumPeople.Text, out int numPpl);
            bool txtTipPercentValid = Double.TryParse(txtTipPercent.Text, out double tipPercent);

            //the following checks if the bool values are valid
            if (txtBillAmtValid && txtNumPeopleValid && txtTipPercentValid)
            {
                //procedes to perform calculations if inputs are valid
                double preTip = billAmt / numPpl;
                double tip = preTip * (tipPercent / 100);
                //checks if checkbox is checked, rounds tip up if it is
                if (checkRound.Checked)
                {
                    tip = Math.Ceiling(tip);
                }
                //calculation happens after checkbox check, as it will affect result
                double total = preTip + tip;

                txtTotalWithTip.Text = total.ToString();
                txtTotalNoTip.Text = preTip.ToString();
                txtTip.Text = tip.ToString();
                //sends number data to string for output
            }
            else
            {
                string message = "";

                if (!txtBillAmtValid)
                {
                    message += "Bill Amount field is invalid\n";
                }
                if (!txtNumPeopleValid)
                {
                    message += "Number of people field is invalid\n";
                }
                if (!txtTipPercentValid)
                {
                    message += "Tip percent field is invalid\n";
                }
                //builds error message string, shows error message
                MessageBox.Show(message, "Error");
            }
        }
    }
}
