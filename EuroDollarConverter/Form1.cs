using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroDollarConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEuroToDollar_Click(object sender, EventArgs e)
        {
            decimal inputEuro;
            decimal course;
            decimal inputDollar;

            inputEuro = Convert.ToDecimal(TxtEuro.Text);

            course = NudCourse.Value;

            inputDollar = inputEuro * course;

            TxtDollar.Text = inputDollar.ToString();
        }

        private void BtnDollarToEuro_Click(object sender, EventArgs e)
        {
            decimal inputEuro;
            decimal course;
            decimal inputDollar;

            inputDollar = Convert.ToDecimal(TxtDollar.Text);

            course = NudCourse.Value;

            inputEuro = inputDollar * course;

            TxtEuro.Text = inputEuro.ToString();
        }
    }
}
