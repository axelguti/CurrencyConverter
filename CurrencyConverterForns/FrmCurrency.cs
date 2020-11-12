using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterForms
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private decimal AusInUS = 2;
        private decimal UKInUS = 0.5M;
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            decimal converted = 0.0M;
            decimal initial = 0.0M;

            initial = Convert.ToDecimal(Amount.Text);
            converted = initial;

            if (FromUK.Checked)
            {
                converted = initial / UKInUS;
            }
            else if (FromAUS.Checked)
            {
                converted = initial / AusInUS;
            }

            if (ToUK.Checked)
            {
                converted = converted * UKInUS;
            }
            else if (ToAus.Checked)
            {
                converted = converted * AusInUS;
            }

            Result.Text = converted.ToString();
        }
    }
}
