
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gRUPODEUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPODECHAMADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTeste = new System.Windows.Forms.Button();
            this.buttonBuscarOS = new System.Windows.Forms.Button();
            this.buttonAbrirOS = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxAtualizar = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.dataGridViewOSAbertas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPBuscarOSAbertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDEMSERVICODataSet = new UIPrincipal.ORDEMSERVICODataSet();
            this.sP_BuscarOSAbertaTableAdapter = new UIPrincipal.ORDEMSERVICODataSetTableAdapters.SP_BuscarOSAbertaTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtualizar)).BeginInit();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSAbertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuscarOSAbertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDEMSERVICODataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
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
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sOBREToolStripMenuItem.Text = "&SOBRE";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sAIRToolStripMenuItem.Text = "&LOGOFF";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTeste);
            this.panel1.Controls.Add(this.buttonBuscarOS);
            this.panel1.Controls.Add(this.buttonAbrirOS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 35);
            this.panel1.TabIndex = 1;
            // 
            // buttonTeste
            // 
            this.buttonTeste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeste.Location = new System.Drawing.Point(585, 0);
            this.buttonTeste.Name = "buttonTeste";
            this.buttonTeste.Size = new System.Drawing.Size(214, 34);
            this.buttonTeste.TabIndex = 3;
            this.buttonTeste.Text = "NÃO CLIQUE AQUI";
            this.buttonTeste.UseVisualStyleBackColor = true;
            this.buttonTeste.Click += new System.EventHandler(this.buttonTeste_Click);
            // 
            // buttonBuscarOS
            // 
            this.buttonBuscarOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarOS.Location = new System.Drawing.Point(322, 7);
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
            this.buttonAbrirOS.Location = new System.Drawing.Point(223, 7);
            this.buttonAbrirOS.Name = "buttonAbrirOS";
            this.buttonAbrirOS.Size = new System.Drawing.Size(75, 24);
            this.buttonAbrirOS.TabIndex = 0;
            this.buttonAbrirOS.Text = "ABRIR &O.S";
            this.buttonAbrirOS.UseVisualStyleBackColor = true;
            this.buttonAbrirOS.Click += new System.EventHandler(this.buttonAbrirOS_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuario,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
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
            // pictureBoxAtualizar
            // 
            this.pictureBoxAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAtualizar.Image")));
            this.pictureBoxAtualizar.Location = new System.Drawing.Point(12, 65);
            this.pictureBoxAtualizar.Name = "pictureBoxAtualizar";
            this.pictureBoxAtualizar.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAtualizar.TabIndex = 4;
            this.pictureBoxAtualizar.TabStop = false;
            this.pictureBoxAtualizar.Click += new System.EventHandler(this.pictureBoxAtualizar_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentro.Controls.Add(this.pictureBoxAtualizar);
            this.panelCentro.Controls.Add(this.dataGridViewOSAbertas);
            this.panelCentro.Location = new System.Drawing.Point(0, 59);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(838, 480);
            this.panelCentro.TabIndex = 3;
            // 
            // dataGridViewOSAbertas
            // 
            this.dataGridViewOSAbertas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewOSAbertas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOSAbertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOSAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOSAbertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.protocoloDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.tipoChamadoDataGridViewTextBoxColumn,
            this.estatusOSDataGridViewTextBoxColumn,
            this.dataAberturaDataGridViewTextBoxColumn,
            this.dataPrazoDataGridViewTextBoxColumn});
            this.dataGridViewOSAbertas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewOSAbertas.DataSource = this.sPBuscarOSAbertaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOSAbertas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOSAbertas.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewOSAbertas.MaximumSize = new System.Drawing.Size(814, 386);
            this.dataGridViewOSAbertas.MinimumSize = new System.Drawing.Size(814, 386);
            this.dataGridViewOSAbertas.Name = "dataGridViewOSAbertas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOSAbertas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOSAbertas.RowHeadersVisible = false;
            this.dataGridViewOSAbertas.Size = new System.Drawing.Size(814, 386);
            this.dataGridViewOSAbertas.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // protocoloDataGridViewTextBoxColumn
            // 
            this.protocoloDataGridViewTextBoxColumn.DataPropertyName = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.HeaderText = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.Name = "protocoloDataGridViewTextBoxColumn";
            this.protocoloDataGridViewTextBoxColumn.Width = 85;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.Width = 290;
            // 
            // tipoChamadoDataGridViewTextBoxColumn
            // 
            this.tipoChamadoDataGridViewTextBoxColumn.DataPropertyName = "TipoChamado";
            this.tipoChamadoDataGridViewTextBoxColumn.HeaderText = "Tipo de Chamado";
            this.tipoChamadoDataGridViewTextBoxColumn.Name = "tipoChamadoDataGridViewTextBoxColumn";
            this.tipoChamadoDataGridViewTextBoxColumn.Width = 160;
            // 
            // estatusOSDataGridViewTextBoxColumn
            // 
            this.estatusOSDataGridViewTextBoxColumn.DataPropertyName = "EstatusOS";
            this.estatusOSDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusOSDataGridViewTextBoxColumn.Name = "estatusOSDataGridViewTextBoxColumn";
            // 
            // dataAberturaDataGridViewTextBoxColumn
            // 
            this.dataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.HeaderText = "Abertura";
            this.dataAberturaDataGridViewTextBoxColumn.Name = "dataAberturaDataGridViewTextBoxColumn";
            this.dataAberturaDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataPrazoDataGridViewTextBoxColumn
            // 
            this.dataPrazoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataPrazoDataGridViewTextBoxColumn.DataPropertyName = "DataPrazo";
            this.dataPrazoDataGridViewTextBoxColumn.HeaderText = "Prazo";
            this.dataPrazoDataGridViewTextBoxColumn.Name = "dataPrazoDataGridViewTextBoxColumn";
            // 
            // sPBuscarOSAbertaBindingSource
            // 
            this.sPBuscarOSAbertaBindingSource.DataMember = "SP_BuscarOSAberta";
            this.sPBuscarOSAbertaBindingSource.DataSource = this.oRDEMSERVICODataSet;
            // 
            // oRDEMSERVICODataSet
            // 
            this.oRDEMSERVICODataSet.DataSetName = "ORDEMSERVICODataSet";
            this.oRDEMSERVICODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_BuscarOSAbertaTableAdapter
            // 
            this.sP_BuscarOSAbertaTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(854, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA O.S";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtualizar)).EndInit();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSAbertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuscarOSAbertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDEMSERVICODataSet)).EndInit();
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
        private System.Windows.Forms.Button buttonTeste;
        private System.Windows.Forms.Button buttonBuscarOS;
        private System.Windows.Forms.ToolStripMenuItem pLANOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPODECHAMADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBoxAtualizar;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.BindingSource sPBuscarOSAbertaBindingSource;
        private ORDEMSERVICODataSet oRDEMSERVICODataSet;
        private ORDEMSERVICODataSetTableAdapters.SP_BuscarOSAbertaTableAdapter sP_BuscarOSAbertaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewOSAbertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrazoDataGridViewTextBoxColumn;
    }
}