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
            this.buttonDeleteLogo = new System.Windows.Forms.Button();
            this.buttonAddLogo = new System.Windows.Forms.Button();
            this.labelLogoOS = new System.Windows.Forms.Label();
            this.pictureBoxLogoOS = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.groupBoxOS = new System.Windows.Forms.GroupBox();
            this.groupBoxCoresSistema = new System.Windows.Forms.GroupBox();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoOS)).BeginInit();
            this.groupBoxOS.SuspendLayout();
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
            // labelLogoOS
            // 
            this.labelLogoOS.AutoSize = true;
            this.labelLogoOS.Location = new System.Drawing.Point(33, 25);
            this.labelLogoOS.Name = "labelLogoOS";
            this.labelLogoOS.Size = new System.Drawing.Size(76, 13);
            this.labelLogoOS.TabIndex = 20;
            this.labelLogoOS.Text = "LOGO DA O.S";
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
            // groupBoxCoresSistema
            // 
            this.groupBoxCoresSistema.ForeColor = System.Drawing.Color.White;
            this.groupBoxCoresSistema.Location = new System.Drawing.Point(3, 149);
            this.groupBoxCoresSistema.Name = "groupBoxCoresSistema";
            this.groupBoxCoresSistema.Size = new System.Drawing.Size(844, 117);
            this.groupBoxCoresSistema.TabIndex = 24;
            this.groupBoxCoresSistema.TabStop = false;
            this.groupBoxCoresSistema.Text = "CORES DO SISTEMA";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoOS)).EndInit();
            this.groupBoxOS.ResumeLayout(false);
            this.groupBoxOS.PerformLayout();
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
    }
}