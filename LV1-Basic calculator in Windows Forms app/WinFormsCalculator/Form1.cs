using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator Casio = new Calculator();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double x = Casio.Add(Convert.ToDouble(inptFirstNumber.Value), Convert.ToDouble(inptSecondNumber.Value));
            inptResult.Text = $"{x}";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double x = Casio.Subtract(Convert.ToDouble(inptFirstNumber.Value), Convert.ToDouble(inptSecondNumber.Value));
            inptResult.Text = $"{x}";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double x = Casio.Multiply(Convert.ToDouble(inptFirstNumber.Value), Convert.ToDouble(inptSecondNumber.Value));
            inptResult.Text = $"{x}";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double x = Casio.Divide(Convert.ToDouble(inptFirstNumber.Value), Convert.ToDouble(inptSecondNumber.Value));
            inptResult.Text = $"{x}";
        }
    }
}
