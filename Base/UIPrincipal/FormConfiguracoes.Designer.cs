namespace UIPrincipal
{
    partial class FormConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracoes));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.groupBoxCoresSistema = new System.Windows.Forms.GroupBox();
            this.buttonCorTextBox = new System.Windows.Forms.Button();
            this.textBoxPersonalizado = new System.Windows.Forms.TextBox();
            this.groupBoxOS = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogoOS = new System.Windows.Forms.PictureBox();
            this.buttonDeleteLogo = new System.Windows.Forms.Button();
            this.labelLogoOS = new System.Windows.Forms.Label();
            this.buttonAddLogo = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.colorDialogSistema = new System.Windows.Forms.ColorDialog();
            this.buttonCorTextoTextBox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.corTextoPrimeiroPlano = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.corDeFundoPrimeiroPlano = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCorTextoComboBox = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCorFundoComboBox = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.groupBoxCoresSistema.SuspendLayout();
            this.groupBoxOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.groupBoxCoresSistema);
            this.panelPrincipal.Controls.Add(this.groupBoxOS);
            this.panelPrincipal.Controls.Add(this.buttonFechar);
            this.panelPrincipal.Controls.Add(this.labelSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(854, 600);
            this.panelPrincipal.TabIndex = 16;
            // 
            // groupBoxCoresSistema
            // 
            this.groupBoxCoresSistema.Controls.Add(this.label8);
            this.groupBoxCoresSistema.Controls.Add(this.comboBox);
            this.groupBoxCoresSistema.Controls.Add(this.buttonCorTextoComboBox);
            this.groupBoxCoresSistema.Controls.Add(this.label6);
            this.groupBoxCoresSistema.Controls.Add(this.buttonCorFundoComboBox);
            this.groupBoxCoresSistema.Controls.Add(this.label7);
            this.groupBoxCoresSistema.Controls.Add(this.corTextoPrimeiroPlano);
            this.groupBoxCoresSistema.Controls.Add(this.label4);
            this.groupBoxCoresSistema.Controls.Add(this.corDeFundoPrimeiroPlano);
            this.groupBoxCoresSistema.Controls.Add(this.label5);
            this.groupBoxCoresSistema.Controls.Add(this.label3);
            this.groupBoxCoresSistema.Controls.Add(this.buttonCorTextoTextBox);
            this.groupBoxCoresSistema.Controls.Add(this.label2);
            this.groupBoxCoresSistema.Controls.Add(this.buttonCorTextBox);
            this.groupBoxCoresSistema.Controls.Add(this.label1);
            this.groupBoxCoresSistema.Controls.Add(this.textBoxPersonalizado);
            this.groupBoxCoresSistema.ForeColor = System.Drawing.Color.White;
            this.groupBoxCoresSistema.Location = new System.Drawing.Point(2, 149);
            this.groupBoxCoresSistema.Name = "groupBoxCoresSistema";
            this.groupBoxCoresSistema.Size = new System.Drawing.Size(844, 225);
            this.groupBoxCoresSistema.TabIndex = 24;
            this.groupBoxCoresSistema.TabStop = false;
            this.groupBoxCoresSistema.Text = "CORES DO SISTEMA";
            // 
            // buttonCorTextBox
            // 
            this.buttonCorTextBox.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCorTextBox.FlatAppearance.BorderSize = 0;
            this.buttonCorTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorTextBox.Image = global::UIPrincipal.Properties.Resources.color_swatch;
            this.buttonCorTextBox.Location = new System.Drawing.Point(4, 58);
            this.buttonCorTextBox.Name = "buttonCorTextBox";
            this.buttonCorTextBox.Size = new System.Drawing.Size(22, 23);
            this.buttonCorTextBox.TabIndex = 24;
            this.buttonCorTextBox.UseVisualStyleBackColor = false;
            this.buttonCorTextBox.Click += new System.EventHandler(this.buttonCorTextBox_Click);
            // 
            // textBoxPersonalizado
            // 
            this.textBoxPersonalizado.Location = new System.Drawing.Point(388, 70);
            this.textBoxPersonalizado.Name = "textBoxPersonalizado";
            this.textBoxPersonalizado.Size = new System.Drawing.Size(450, 20);
            this.textBoxPersonalizado.TabIndex = 0;
            this.textBoxPersonalizado.Text = "Exemplo de Texto";
            // 
            // groupBoxOS
            // 
            this.groupBoxOS.Controls.Add(this.pictureBoxLogoOS);
            this.groupBoxOS.Controls.Add(this.buttonDeleteLogo);
            this.groupBoxOS.Controls.Add(this.labelLogoOS);
            this.groupBoxOS.Controls.Add(this.buttonAddLogo);
            this.groupBoxOS.ForeColor = System.Drawing.Color.White;
            this.groupBoxOS.Location = new System.Drawing.Point(3, 26);
            this.groupBoxOS.Name = "groupBoxOS";
            this.groupBoxOS.Size = new System.Drawing.Size(844, 117);
            this.groupBoxOS.TabIndex = 23;
            this.groupBoxOS.TabStop = false;
            this.groupBoxOS.Text = "O.S";
            // 
            // pictureBoxLogoOS
            // 
            this.pictureBoxLogoOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogoOS.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoOS.ErrorImage")));
            this.pictureBoxLogoOS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoOS.Image")));
            this.pictureBoxLogoOS.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoOS.InitialImage")));
            this.pictureBoxLogoOS.Location = new System.Drawing.Point(33, 41);
            this.pictureBoxLogoOS.Name = "pictureBoxLogoOS";
            this.pictureBoxLogoOS.Size = new System.Drawing.Size(120, 50);
            this.pictureBoxLogoOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoOS.TabIndex = 18;
            this.pictureBoxLogoOS.TabStop = false;
            // 
            // buttonDeleteLogo
            // 
            this.buttonDeleteLogo.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteLogo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDeleteLogo.FlatAppearance.BorderSize = 0;
            this.buttonDeleteLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteLogo.Image = global::UIPrincipal.Properties.Resources.delete;
            this.buttonDeleteLogo.Location = new System.Drawing.Point(155, 68);
            this.buttonDeleteLogo.Name = "buttonDeleteLogo";
            this.buttonDeleteLogo.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteLogo.TabIndex = 22;
            this.buttonDeleteLogo.UseVisualStyleBackColor = false;
            this.buttonDeleteLogo.Click += new System.EventHandler(this.buttonDeleteLogo_Click);
            // 
            // labelLogoOS
            // 
            this.labelLogoOS.AutoSize = true;
            this.labelLogoOS.Location = new System.Drawing.Point(33, 25);
            this.labelLogoOS.Name = "labelLogoOS";
            this.labelLogoOS.Size = new System.Drawing.Size(76, 13);
            this.labelLogoOS.TabIndex = 20;
            this.labelLogoOS.Text = "LOGO DA O.S";
            // 
            // buttonAddLogo
            // 
            this.buttonAddLogo.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddLogo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddLogo.FlatAppearance.BorderSize = 0;
            this.buttonAddLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLogo.Image = global::UIPrincipal.Properties.Resources.add;
            this.buttonAddLogo.Location = new System.Drawing.Point(155, 41);
            this.buttonAddLogo.Name = "buttonAddLogo";
            this.buttonAddLogo.Size = new System.Drawing.Size(23, 23);
            this.buttonAddLogo.TabIndex = 21;
            this.buttonAddLogo.UseVisualStyleBackColor = false;
            this.buttonAddLogo.Click += new System.EventHandler(this.buttonAddLogo_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.DimGray;
            this.buttonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Image = global::UIPrincipal.Properties.Resources.cancel;
            this.buttonFechar.Location = new System.Drawing.Point(824, -1);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(23, 23);
            this.buttonFechar.TabIndex = 15;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelSuperior
            // 
            this.labelSuperior.BackColor = System.Drawing.Color.DimGray;
            this.labelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuperior.Location = new System.Drawing.Point(0, 0);
            this.labelSuperior.Name = "labelSuperior";
            this.labelSuperior.Size = new System.Drawing.Size(850, 23);
            this.labelSuperior.TabIndex = 17;
            this.labelSuperior.Text = "CONFIGURAÇÕES";
            this.labelSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCorTextoTextBox
            // 
            this.buttonCorTextoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorTextoTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCorTextoTextBox.FlatAppearance.BorderSize = 0;
            this.buttonCorTextoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorTextoTextBox.Image = global::UIPrincipal.Properties.Resources.color_swatch;
            this.buttonCorTextoTextBox.Location = new System.Drawing.Point(4, 78);
            this.buttonCorTextoTextBox.Name = "buttonCorTextoTextBox";
            this.buttonCorTextoTextBox.Size = new System.Drawing.Size(22, 23);
            this.buttonCorTextoTextBox.TabIndex = 26;
            this.buttonCorTextoTextBox.UseVisualStyleBackColor = false;
            this.buttonCorTextoTextBox.Click += new System.EventHandler(this.buttonCorTextoTextBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "COR DO TEXTO DO TEXT BOX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "COR DO FUNDO DO TEXT BOX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "TEXT BOX:";
            // 
            // corTextoPrimeiroPlano
            // 
            this.corTextoPrimeiroPlano.BackColor = System.Drawing.Color.Transparent;
            this.corTextoPrimeiroPlano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corTextoPrimeiroPlano.FlatAppearance.BorderSize = 0;
            this.corTextoPrimeiroPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corTextoPrimeiroPlano.Image = global::UIPrincipal.Properties.Resources.color_swatch;
            this.corTextoPrimeiroPlano.Location = new System.Drawing.Point(4, 38);
            this.corTextoPrimeiroPlano.Name = "corTextoPrimeiroPlano";
            this.corTextoPrimeiroPlano.Size = new System.Drawing.Size(22, 23);
            this.corTextoPrimeiroPlano.TabIndex = 31;
            this.corTextoPrimeiroPlano.UseVisualStyleBackColor = false;
            this.corTextoPrimeiroPlano.Click += new System.EventHandler(this.corTextoPrimeiroPlano_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "COR DO TEXTO GERAL";
            // 
            // corDeFundoPrimeiroPlano
            // 
            this.corDeFundoPrimeiroPlano.BackColor = System.Drawing.Color.Transparent;
            this.corDeFundoPrimeiroPlano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corDeFundoPrimeiroPlano.FlatAppearance.BorderSize = 0;
            this.corDeFundoPrimeiroPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corDeFundoPrimeiroPlano.Image = global::UIPrincipal.Properties.Resources.color_swatch;
            this.corDeFundoPrimeiroPlano.Location = new System.Drawing.Point(4, 18);
            this.corDeFundoPrimeiroPlano.Name = "corDeFundoPrimeiroPlano";
            this.corDeFundoPrimeiroPlano.Size = new System.Drawing.Size(22, 23);
            this.corDeFundoPrimeiroPlano.TabIndex = 29;
            this.corDeFundoPrimeiroPlano.UseVisualStyleBackColor = false;
            this.corDeFundoPrimeiroPlano.Click += new System.EventHandler(this.corDeFundoPrimeiroPlano_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "COR DE FUNDO";
            // 
            // buttonCorTextoComboBox
            // 
            this.buttonCorTextoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorTextoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCorTextoComboBox.FlatAppearance.BorderSize = 0;
            this.buttonCorTextoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorTextoComboBox.Image = global::UIPrincipal.Properties.Resources.color_swatch;
            this.buttonCorTextoComboBox.Location = new System.Drawing.Point(4, 118);
            this.buttonCorTextoComboBox.Name = "buttonCorTextoComboBox";
            this.buttonCorTextoComboBox.Size = new System.Drawing.Size(22, 23);
            this.buttonCorTextoComboBox.TabIndex = 35;
            this.buttonCorTextoComboBox.UseVisualStyleBackColor = false;
            this.buttonCorTextoComboBox.Click += new System.EventHandler(this.buttonCorTextoComboBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "COR DO TEXTO DO COMBO BOX";
            // 
            // buttonCorFundoComboBox
            // 
            this.buttonCorFundoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorFundoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCorFundoComboBox.FlatAppearance.BorderSize = 0;
            this.buttonCorFundoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorFundoComboBox.Image = global::UIPrincipal.Properties.Resources.color_swatch;
            this.buttonCorFundoComboBox.Location = new System.Drawing.Point(4, 98);
            this.buttonCorFundoComboBox.Name = "buttonCorFundoComboBox";
            this.buttonCorFundoComboBox.Size = new System.Drawing.Size(22, 23);
            this.buttonCorFundoComboBox.TabIndex = 33;
            this.buttonCorFundoComboBox.UseVisualStyleBackColor = false;
            this.buttonCorFundoComboBox.Click += new System.EventHandler(this.buttonCorFundoComboBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "COR DO FUNDO DO COMBO BOX";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(388, 109);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(449, 21);
            this.comboBox.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "COMBO BOX:";
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.buttonFechar;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.panelPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfiguracoes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelPrincipal.ResumeLayout(false);
            this.groupBoxCoresSistema.ResumeLayout(false);
            this.groupBoxCoresSistema.PerformLayout();
            this.groupBoxOS.ResumeLayout(false);
            this.groupBoxOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelSuperior;
        private System.Windows.Forms.PictureBox pictureBoxLogoOS;
        private System.Windows.Forms.Button buttonDeleteLogo;
        private System.Windows.Forms.Button buttonAddLogo;
        private System.Windows.Forms.Label labelLogoOS;
        private System.Windows.Forms.GroupBox groupBoxCoresSistema;
        private System.Windows.Forms.GroupBox groupBoxOS;
        private System.Windows.Forms.Button buttonCorTextBox;
        private System.Windows.Forms.TextBox textBoxPersonalizado;
        private System.Windows.Forms.ColorDialog colorDialogSistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCorTextoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button corTextoPrimeiroPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button corDeFundoPrimeiroPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonCorTextoComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCorFundoComboBox;
        private System.Windows.Forms.Label label7;
    }
}