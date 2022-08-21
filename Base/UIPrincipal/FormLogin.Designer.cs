
namespace UIPrincipal
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.labelInformacaoErro = new System.Windows.Forms.Label();
            this.labelServidor = new System.Windows.Forms.Label();
            this.comboBoxEnderecoDoBanco = new System.Windows.Forms.ComboBox();
            this.buttonConfirmarServidor = new System.Windows.Forms.Button();
            this.buttonAddServidor = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(281, 188);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "LOGAR";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Black;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(362, 188);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.White;
            this.textBoxUsuario.Location = new System.Drawing.Point(254, 65);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(208, 20);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            this.textBoxSenha.Location = new System.Drawing.Point(254, 133);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(208, 20);
            this.textBoxSenha.TabIndex = 1;
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(251, 49);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(45, 13);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "LOGIN";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(251, 117);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(49, 13);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "SENHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxLogin.Controls.Add(this.labelInformacaoErro);
            this.groupBoxLogin.Controls.Add(this.pictureBox1);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.labelSenha);
            this.groupBoxLogin.Controls.Add(this.buttonSair);
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxLogin.Location = new System.Drawing.Point(168, 34);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(494, 230);
            this.groupBoxLogin.TabIndex = 7;
            this.groupBoxLogin.TabStop = false;
            // 
            // labelInformacaoErro
            // 
            this.labelInformacaoErro.AutoSize = true;
            this.labelInformacaoErro.ForeColor = System.Drawing.Color.Red;
            this.labelInformacaoErro.Location = new System.Drawing.Point(251, 88);
            this.labelInformacaoErro.Name = "labelInformacaoErro";
            this.labelInformacaoErro.Size = new System.Drawing.Size(0, 13);
            this.labelInformacaoErro.TabIndex = 7;
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.ForeColor = System.Drawing.Color.White;
            this.labelServidor.Location = new System.Drawing.Point(165, 269);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(137, 13);
            this.labelServidor.TabIndex = 9;
            this.labelServidor.Text = "SELECIONAR SERVIDOR:";
            // 
            // comboBoxEnderecoDoBanco
            // 
            this.comboBoxEnderecoDoBanco.FormattingEnabled = true;
            this.comboBoxEnderecoDoBanco.Location = new System.Drawing.Point(168, 285);
            this.comboBoxEnderecoDoBanco.Name = "comboBoxEnderecoDoBanco";
            this.comboBoxEnderecoDoBanco.Size = new System.Drawing.Size(408, 21);
            this.comboBoxEnderecoDoBanco.TabIndex = 8;
            this.comboBoxEnderecoDoBanco.SelectedIndexChanged += new System.EventHandler(this.comboBoxEnderecoDoBanco_SelectedIndexChanged);
            this.comboBoxEnderecoDoBanco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxEnderecoDoBanco_MouseClick);
            // 
            // buttonConfirmarServidor
            // 
            this.buttonConfirmarServidor.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirmarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarServidor.Image = global::UIPrincipal.Properties.Resources.server_go;
            this.buttonConfirmarServidor.Location = new System.Drawing.Point(611, 283);
            this.buttonConfirmarServidor.Name = "buttonConfirmarServidor";
            this.buttonConfirmarServidor.Size = new System.Drawing.Size(23, 23);
            this.buttonConfirmarServidor.TabIndex = 11;
            this.buttonConfirmarServidor.UseVisualStyleBackColor = false;
            this.buttonConfirmarServidor.Click += new System.EventHandler(this.buttonConfirmarServidor_Click);
            // 
            // buttonAddServidor
            // 
            this.buttonAddServidor.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddServidor.Image = global::UIPrincipal.Properties.Resources.server_add;
            this.buttonAddServidor.Location = new System.Drawing.Point(640, 283);
            this.buttonAddServidor.Name = "buttonAddServidor";
            this.buttonAddServidor.Size = new System.Drawing.Size(23, 23);
            this.buttonAddServidor.TabIndex = 12;
            this.buttonAddServidor.UseVisualStyleBackColor = false;
            this.buttonAddServidor.Click += new System.EventHandler(this.buttonAddServidor_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.buttonAtualizar);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(834, 349);
            this.panelLogin.TabIndex = 13;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Image = global::UIPrincipal.Properties.Resources.arrow_refresh;
            this.buttonAtualizar.Location = new System.Drawing.Point(580, 281);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(23, 23);
            this.buttonAtualizar.TabIndex = 14;
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 349);
            this.Controls.Add(this.buttonAddServidor);
            this.Controls.Add(this.buttonConfirmarServidor);
            this.Controls.Add(this.labelServidor);
            this.Controls.Add(this.comboBoxEnderecoDoBanco);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelInformacaoErro;
        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.ComboBox comboBoxEnderecoDoBanco;
        private System.Windows.Forms.Button buttonConfirmarServidor;
        private System.Windows.Forms.Button buttonAddServidor;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}