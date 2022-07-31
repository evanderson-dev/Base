
namespace UIPrincipal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gRUPODEUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPODECHAMADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBuscarOS = new System.Windows.Forms.Button();
            this.buttonAbrirOS = new System.Windows.Forms.Button();
            this.buttonTeste = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRUPODEUSUARIOToolStripMenuItem,
            this.aJUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gRUPODEUSUARIOToolStripMenuItem
            // 
            this.gRUPODEUSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.tIPODECHAMADOToolStripMenuItem,
            this.pLANOToolStripMenuItem});
            this.gRUPODEUSUARIOToolStripMenuItem.Name = "gRUPODEUSUARIOToolStripMenuItem";
            this.gRUPODEUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.gRUPODEUSUARIOToolStripMenuItem.Text = "&CADASTRO";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.uSUARIOSToolStripMenuItem.Text = "&FUNCIONARIO/CLIENTE";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // tIPODECHAMADOToolStripMenuItem
            // 
            this.tIPODECHAMADOToolStripMenuItem.Name = "tIPODECHAMADOToolStripMenuItem";
            this.tIPODECHAMADOToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.tIPODECHAMADOToolStripMenuItem.Text = "TIPO DE CHAMADO";
            this.tIPODECHAMADOToolStripMenuItem.Click += new System.EventHandler(this.tIPODECHAMADOToolStripMenuItem_Click);
            // 
            // pLANOToolStripMenuItem
            // 
            this.pLANOToolStripMenuItem.Name = "pLANOToolStripMenuItem";
            this.pLANOToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pLANOToolStripMenuItem.Text = "&PLANO";
            this.pLANOToolStripMenuItem.Click += new System.EventHandler(this.pLANOToolStripMenuItem_Click);
            // 
            // aJUDAToolStripMenuItem
            // 
            this.aJUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOBREToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            this.aJUDAToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aJUDAToolStripMenuItem.Text = "&AJUDA";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sOBREToolStripMenuItem.Text = "&SOBRE";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sAIRToolStripMenuItem.Text = "&LOGOFF";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonBuscarOS);
            this.panel1.Controls.Add(this.buttonAbrirOS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(404, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarOS
            // 
            this.buttonBuscarOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarOS.Location = new System.Drawing.Point(295, 40);
            this.buttonBuscarOS.Name = "buttonBuscarOS";
            this.buttonBuscarOS.Size = new System.Drawing.Size(83, 24);
            this.buttonBuscarOS.TabIndex = 1;
            this.buttonBuscarOS.Text = "BUSCAR O.S";
            this.buttonBuscarOS.UseVisualStyleBackColor = true;
            this.buttonBuscarOS.Click += new System.EventHandler(this.buttonBuscarOS_Click);
            // 
            // buttonAbrirOS
            // 
            this.buttonAbrirOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAbrirOS.Location = new System.Drawing.Point(196, 40);
            this.buttonAbrirOS.Name = "buttonAbrirOS";
            this.buttonAbrirOS.Size = new System.Drawing.Size(75, 24);
            this.buttonAbrirOS.TabIndex = 0;
            this.buttonAbrirOS.Text = "ABRIR &O.S";
            this.buttonAbrirOS.UseVisualStyleBackColor = true;
            this.buttonAbrirOS.Click += new System.EventHandler(this.buttonAbrirOS_Click);
            // 
            // buttonTeste
            // 
            this.buttonTeste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeste.Location = new System.Drawing.Point(261, 130);
            this.buttonTeste.Name = "buttonTeste";
            this.buttonTeste.Size = new System.Drawing.Size(292, 87);
            this.buttonTeste.TabIndex = 3;
            this.buttonTeste.Text = "NÃO CLIQUE AQUI";
            this.buttonTeste.UseVisualStyleBackColor = true;
            this.buttonTeste.Click += new System.EventHandler(this.buttonTeste_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuario,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuario
            // 
            this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabelUsuario.Text = "USUARIO";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel1.Text = " :LOGADO COMO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonTeste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA O.S";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gRUPODEUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbrirOS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTeste;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBuscarOS;
        private System.Windows.Forms.ToolStripMenuItem pLANOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPODECHAMADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}