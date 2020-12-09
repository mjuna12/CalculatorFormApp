using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorEventApp
{
    public partial class CalculatorUtama : Form
    {
       
        public CalculatorUtama()
        {
            InitializeComponent();
        }

        private void CalculatorUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {

            FrmCalculator getFrmCalculator = new FrmCalculator();
            getFrmCalculator.OnProses += new FrmCalculator.AplikasiKalkulator(this.Callback);
            float num = (float)getFrmCalculator.ShowDialog();
        }

        private void Callback(string name, string symbol, float a, float b, float hasil)
        {
            lvwHasil.Items.Add("Hasil " + name + " " + a + " " + symbol + " " + b + " = " + hasil);
        }
    }
}
