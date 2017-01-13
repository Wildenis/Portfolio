using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentificandoIdade
{
    public partial class FormIdentificandoIdade : Form
    {
        public FormIdentificandoIdade()
        {
            InitializeComponent();
        }

        private void btnIdentificarIdade_Click(object sender, EventArgs e)
        {
            int Idade;
            Idade = DateTime.Now.Year - dtpNascimento.Value.Year;
            MessageBox.Show(Idade.ToString());
            lblIdade.Visible = true;
            lblIdade.Text = "" + Idade.ToString();

        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
