namespace UIPrincipal
{
    partial class FormParaTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParaTeste));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxEnderecoDoBanco = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(354, 98);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(142, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "BUSCAR ARQUIVOS";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxEnderecoDoBanco
            // 
            this.comboBoxEnderecoDoBanco.FormattingEnabled = true;
            this.comboBoxEnderecoDoBanco.Location = new System.Drawing.Point(12, 127);
            this.comboBoxEnderecoDoBanco.Name = "comboBoxEnderecoDoBanco";
            this.comboBoxEnderecoDoBanco.Size = new System.Drawing.Size(830, 21);
            this.comboBoxEnderecoDoBanco.TabIndex = 1;
            // 
            // FormParaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.comboBoxEnderecoDoBanco);
            this.Controls.Add(this.buttonBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormParaTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormParaTeste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxEnderecoDoBanco;
    }
}