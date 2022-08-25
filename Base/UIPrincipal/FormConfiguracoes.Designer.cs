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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddLogo = new System.Windows.Forms.Button();
            this.labelLogoOS = new System.Windows.Forms.Label();
            this.pictureBoxLogoOS = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.button2);
            this.panelPrincipal.Controls.Add(this.buttonAddLogo);
            this.panelPrincipal.Controls.Add(this.labelLogoOS);
            this.panelPrincipal.Controls.Add(this.pictureBoxLogoOS);
            this.panelPrincipal.Controls.Add(this.buttonFechar);
            this.panelPrincipal.Controls.Add(this.labelSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(854, 600);
            this.panelPrincipal.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::UIPrincipal.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(136, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonAddLogo
            // 
            this.buttonAddLogo.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddLogo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddLogo.FlatAppearance.BorderSize = 0;
            this.buttonAddLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLogo.Image = global::UIPrincipal.Properties.Resources.add;
            this.buttonAddLogo.Location = new System.Drawing.Point(136, 49);
            this.buttonAddLogo.Name = "buttonAddLogo";
            this.buttonAddLogo.Size = new System.Drawing.Size(23, 23);
            this.buttonAddLogo.TabIndex = 21;
            this.buttonAddLogo.UseVisualStyleBackColor = false;
            this.buttonAddLogo.Click += new System.EventHandler(this.buttonAddLogo_Click);
            // 
            // labelLogoOS
            // 
            this.labelLogoOS.AutoSize = true;
            this.labelLogoOS.Location = new System.Drawing.Point(10, 33);
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
            this.pictureBoxLogoOS.Location = new System.Drawing.Point(10, 49);
            this.pictureBoxLogoOS.Name = "pictureBoxLogoOS";
            this.pictureBoxLogoOS.Size = new System.Drawing.Size(120, 50);
            this.pictureBoxLogoOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoOS.TabIndex = 18;
            this.pictureBoxLogoOS.TabStop = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.DimGray;
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
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelSuperior;
        private System.Windows.Forms.PictureBox pictureBoxLogoOS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddLogo;
        private System.Windows.Forms.Label labelLogoOS;
    }
}