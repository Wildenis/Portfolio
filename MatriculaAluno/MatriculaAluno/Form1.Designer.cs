namespace MatriculaAluno
{
    partial class MatriculaAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.lbUltimoAniversario = new System.Windows.Forms.Label();
            this.txtUltimoAnoNiver = new System.Windows.Forms.TextBox();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 17);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(12, 56);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(133, 17);
            this.lbNascimento.TabIndex = 2;
            this.lbNascimento.Text = "&Ano de nascimento:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(151, 55);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(62, 20);
            this.txtAnoNascimento.TabIndex = 3;
            // 
            // lbUltimoAniversario
            // 
            this.lbUltimoAniversario.AutoSize = true;
            this.lbUltimoAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltimoAniversario.Location = new System.Drawing.Point(233, 56);
            this.lbUltimoAniversario.Name = "lbUltimoAniversario";
            this.lbUltimoAniversario.Size = new System.Drawing.Size(152, 17);
            this.lbUltimoAniversario.TabIndex = 4;
            this.lbUltimoAniversario.Text = "An&o último aniversário:";
            // 
            // txtUltimoAnoNiver
            // 
            this.txtUltimoAnoNiver.Location = new System.Drawing.Point(391, 55);
            this.txtUltimoAnoNiver.Name = "txtUltimoAnoNiver";
            this.txtUltimoAnoNiver.Size = new System.Drawing.Size(62, 20);
            this.txtUltimoAnoNiver.TabIndex = 5;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificar.Location = new System.Drawing.Point(44, 108);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(144, 24);
            this.btnIdentificar.TabIndex = 6;
            this.btnIdentificar.Text = "Identificar categoria";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(247, 112);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(73, 17);
            this.lbCategoria.TabIndex = 7;
            this.lbCategoria.Text = "&Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCategoria.Location = new System.Drawing.Point(326, 111);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(127, 20);
            this.txtCategoria.TabIndex = 8;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // MatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 149);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.txtUltimoAnoNiver);
            this.Controls.Add(this.lbUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Name = "MatriculaAluno";
            this.Text = "Matrícular de aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label lbUltimoAniversario;
        private System.Windows.Forms.TextBox txtUltimoAnoNiver;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}

