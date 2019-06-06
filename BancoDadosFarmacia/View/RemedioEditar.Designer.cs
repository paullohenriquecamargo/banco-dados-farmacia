namespace View
{
    partial class RemedioEditar
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblPrecisaReceita = new System.Windows.Forms.Label();
            this.rbGenerico = new System.Windows.Forms.RadioButton();
            this.rbSolido = new System.Windows.Forms.RadioButton();
            this.txtFaixa = new System.Windows.Forms.TextBox();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.txtBula = new System.Windows.Forms.TextBox();
            this.lblBula = new System.Windows.Forms.Label();
            this.txtContraIndicacoes = new System.Windows.Forms.TextBox();
            this.lblContraIndicacoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 35);
            this.txtNome.TabIndex = 47;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 29);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(94, 249);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(79, 33);
            this.rbNao.TabIndex = 39;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(12, 249);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(76, 33);
            this.rbSim.TabIndex = 38;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(9, 147);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(127, 29);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 109);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(302, 35);
            this.txtId.TabIndex = 35;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(9, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 29);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "Id";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(165, 429);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 82);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(11, 179);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(302, 35);
            this.txtCategoria.TabIndex = 48;
            // 
            // lblPrecisaReceita
            // 
            this.lblPrecisaReceita.AutoSize = true;
            this.lblPrecisaReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecisaReceita.Location = new System.Drawing.Point(12, 217);
            this.lblPrecisaReceita.Name = "lblPrecisaReceita";
            this.lblPrecisaReceita.Size = new System.Drawing.Size(217, 29);
            this.lblPrecisaReceita.TabIndex = 49;
            this.lblPrecisaReceita.Text = "Precisa Receita ?";
            // 
            // rbGenerico
            // 
            this.rbGenerico.AutoSize = true;
            this.rbGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenerico.Location = new System.Drawing.Point(11, 288);
            this.rbGenerico.Name = "rbGenerico";
            this.rbGenerico.Size = new System.Drawing.Size(138, 33);
            this.rbGenerico.TabIndex = 50;
            this.rbGenerico.TabStop = true;
            this.rbGenerico.Text = "Generico";
            this.rbGenerico.UseVisualStyleBackColor = true;
            // 
            // rbSolido
            // 
            this.rbSolido.AutoSize = true;
            this.rbSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolido.Location = new System.Drawing.Point(11, 327);
            this.rbSolido.Name = "rbSolido";
            this.rbSolido.Size = new System.Drawing.Size(107, 33);
            this.rbSolido.TabIndex = 51;
            this.rbSolido.TabStop = true;
            this.rbSolido.Text = "Sólido";
            this.rbSolido.UseVisualStyleBackColor = true;
            // 
            // txtFaixa
            // 
            this.txtFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaixa.Location = new System.Drawing.Point(12, 388);
            this.txtFaixa.Name = "txtFaixa";
            this.txtFaixa.Size = new System.Drawing.Size(302, 35);
            this.txtFaixa.TabIndex = 53;
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(9, 356);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(76, 29);
            this.lblFaixa.TabIndex = 52;
            this.lblFaixa.Text = "Faixa";
            // 
            // txtBula
            // 
            this.txtBula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBula.Location = new System.Drawing.Point(320, 39);
            this.txtBula.Name = "txtBula";
            this.txtBula.Size = new System.Drawing.Size(302, 35);
            this.txtBula.TabIndex = 55;
            // 
            // lblBula
            // 
            this.lblBula.AutoSize = true;
            this.lblBula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBula.Location = new System.Drawing.Point(317, 7);
            this.lblBula.Name = "lblBula";
            this.lblBula.Size = new System.Drawing.Size(65, 29);
            this.lblBula.TabIndex = 54;
            this.lblBula.Text = "Bula";
            // 
            // txtContraIndicacoes
            // 
            this.txtContraIndicacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraIndicacoes.Location = new System.Drawing.Point(322, 109);
            this.txtContraIndicacoes.Name = "txtContraIndicacoes";
            this.txtContraIndicacoes.Size = new System.Drawing.Size(302, 35);
            this.txtContraIndicacoes.TabIndex = 57;
            // 
            // lblContraIndicacoes
            // 
            this.lblContraIndicacoes.AutoSize = true;
            this.lblContraIndicacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIndicacoes.Location = new System.Drawing.Point(319, 77);
            this.lblContraIndicacoes.Name = "lblContraIndicacoes";
            this.lblContraIndicacoes.Size = new System.Drawing.Size(223, 29);
            this.lblContraIndicacoes.TabIndex = 56;
            this.lblContraIndicacoes.Text = "Contra Indicações";
            // 
            // RemedioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 520);
            this.Controls.Add(this.txtContraIndicacoes);
            this.Controls.Add(this.lblContraIndicacoes);
            this.Controls.Add(this.txtBula);
            this.Controls.Add(this.lblBula);
            this.Controls.Add(this.txtFaixa);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.rbSolido);
            this.Controls.Add(this.rbGenerico);
            this.Controls.Add(this.lblPrecisaReceita);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Name = "RemedioEditar";
            this.Text = "RemedioEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblPrecisaReceita;
        private System.Windows.Forms.RadioButton rbGenerico;
        private System.Windows.Forms.RadioButton rbSolido;
        private System.Windows.Forms.TextBox txtFaixa;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.TextBox txtBula;
        private System.Windows.Forms.Label lblBula;
        private System.Windows.Forms.TextBox txtContraIndicacoes;
        private System.Windows.Forms.Label lblContraIndicacoes;
    }
}