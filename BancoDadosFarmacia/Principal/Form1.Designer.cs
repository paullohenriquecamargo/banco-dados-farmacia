namespace Principal
{
    partial class Principal
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
            this.btnCadastrodeRemedios = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrodeRemedios
            // 
            this.btnCadastrodeRemedios.Font = new System.Drawing.Font("News706 BT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrodeRemedios.Location = new System.Drawing.Point(278, 12);
            this.btnCadastrodeRemedios.Name = "btnCadastrodeRemedios";
            this.btnCadastrodeRemedios.Size = new System.Drawing.Size(290, 124);
            this.btnCadastrodeRemedios.TabIndex = 0;
            this.btnCadastrodeRemedios.Text = "Cadastro de Remédios";
            this.btnCadastrodeRemedios.UseVisualStyleBackColor = true;
            this.btnCadastrodeRemedios.Click += new System.EventHandler(this.btnCadastrodeRemedios_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastrodeRemedios);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrodeRemedios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

