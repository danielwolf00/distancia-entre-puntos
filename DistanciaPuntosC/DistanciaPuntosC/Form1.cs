using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanciaPuntosC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            double d = 0;
            d = Math.Sqrt(Math.Pow(double.Parse(txtX1.Text) - double.Parse(txtX2.Text), 2) + (Math.Pow(double.Parse(txtY1 .Text) - double.Parse(txtY2 .Text), 2)));
            dis.Text = d.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            OnResizeEnd
        }
    }
}
