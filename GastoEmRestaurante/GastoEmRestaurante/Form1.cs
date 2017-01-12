using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoEmRestaurante
{
    public partial class GastosEmRestaurantes : Form
    {
        public GastosEmRestaurantes()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (double.Parse(txtDespesas.Text) * 1.10).ToString("N");
        }

        private void txtDespesas_TextChanged(object sender, EventArgs e)
        {
            if (txtDespesas.TextLength == 0)
            {
                btnCalcular.Enabled = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
