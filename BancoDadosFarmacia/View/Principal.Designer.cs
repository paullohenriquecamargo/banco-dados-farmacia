namespace View
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
            this.SuspendLayout();
            // 
            // btnCadastrodeRemedios
            // 
            this.btnCadastrodeRemedios.Font = new System.Drawing.Font("Revit_HEB_DWG", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrodeRemedios.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrodeRemedios.Name = "btnCadastrodeRemedios";
            this.btnCadastrodeRemedios.Size = new System.Drawing.Size(265, 204);
            this.btnCadastrodeRemedios.TabIndex = 0;
            this.btnCadastrodeRemedios.Text = "Cadastro de Remédios";
            this.btnCadastrodeRemedios.UseVisualStyleBackColor = true;
            this.btnCadastrodeRemedios.Click += new System.EventHandler(this.btnCadastrodeRemedios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrodeRemedios);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrodeRemedios;
    }
}