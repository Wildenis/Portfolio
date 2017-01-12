using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class MatriculaAluno : Form
    {
        public MatriculaAluno()
        {
            InitializeComponent();
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            int idade;
            idade = (int.Parse(txtUltimoAnoNiver.Text) - int.Parse(txtAnoNascimento.Text)); 
            if (idade > 0 && idade < 7) 
            {
                txtCategoria.Text = "Infantil A";
            } else if (idade > 8 && idade < 10)
            {
                txtCategoria.Text = "Infantil B";
            } else if (idade > 11 && idade < 13)
            {
                txtCategoria.Text = "Juvenil A";
            } else if (idade > 14 && idade < 17)
            {
                txtCategoria.Text = "Juvenil B";
            } else if (idade > 18)
            {
                txtCategoria.Text = "Adulto";
            }

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
