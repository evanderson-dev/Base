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
            this.textBoxGravarBanco = new System.Windows.Forms.TextBox();
            this.comboBoxServidores = new System.Windows.Forms.ComboBox();
            this.buttonGravarBanco = new System.Windows.Forms.Button();
            this.comboBoxEnderecoDoBanco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGerenciarServidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGravarBanco
            // 
            this.textBoxGravarBanco.Location = new System.Drawing.Point(178, 96);
            this.textBoxGravarBanco.Name = "textBoxGravarBanco";
            this.textBoxGravarBanco.Size = new System.Drawing.Size(500, 20);
            this.textBoxGravarBanco.TabIndex = 0;
            // 
            // comboBoxServidores
            // 
            this.comboBoxServidores.FormattingEnabled = true;
            this.comboBoxServidores.Location = new System.Drawing.Point(178, 181);
            this.comboBoxServidores.Name = "comboBoxServidores";
            this.comboBoxServidores.Size = new System.Drawing.Size(500, 21);
            this.comboBoxServidores.TabIndex = 1;
            this.comboBoxServidores.Click += new System.EventHandler(this.comboBoxServidores_Click);
            // 
            // buttonGravarBanco
            // 
            this.buttonGravarBanco.Location = new System.Drawing.Point(372, 122);
            this.buttonGravarBanco.Name = "buttonGravarBanco";
            this.buttonGravarBanco.Size = new System.Drawing.Size(102, 23);
            this.buttonGravarBanco.TabIndex = 2;
            this.buttonGravarBanco.Text = "GRAVAR BANCO";
            this.buttonGravarBanco.UseVisualStyleBackColor = true;
            this.buttonGravarBanco.Click += new System.EventHandler(this.buttonGravarBanco_Click);
            // 
            // comboBoxEnderecoDoBanco
            // 
            this.comboBoxEnderecoDoBanco.FormattingEnabled = true;
            this.comboBoxEnderecoDoBanco.Location = new System.Drawing.Point(178, 312);
            this.comboBoxEnderecoDoBanco.Name = "comboBoxEnderecoDoBanco";
            this.comboBoxEnderecoDoBanco.Size = new System.Drawing.Size(500, 21);
            this.comboBoxEnderecoDoBanco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DADOS DO ARQUIVO TXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DADOS DO BANCO";
            // 
            // buttonGerenciarServidor
            // 
            this.buttonGerenciarServidor.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonGerenciarServidor.Location = new System.Drawing.Point(684, 311);
            this.buttonGerenciarServidor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGerenciarServidor.Name = "buttonGerenciarServidor";
            this.buttonGerenciarServidor.Size = new System.Drawing.Size(32, 23);
            this.buttonGerenciarServidor.TabIndex = 6;
            this.buttonGerenciarServidor.Text = "...";
            this.buttonGerenciarServidor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGerenciarServidor.UseVisualStyleBackColor = true;
            this.buttonGerenciarServidor.Click += new System.EventHandler(this.buttonGerenciarServidor_Click);
            // 
            // FormParaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.buttonGerenciarServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEnderecoDoBanco);
            this.Controls.Add(this.buttonGravarBanco);
            this.Controls.Add(this.comboBoxServidores);
            this.Controls.Add(this.textBoxGravarBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormParaTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormParaTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGravarBanco;
        private System.Windows.Forms.ComboBox comboBoxServidores;
        private System.Windows.Forms.Button buttonGravarBanco;
        private System.Windows.Forms.ComboBox comboBoxEnderecoDoBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGerenciarServidor;
    }
}