
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
            System.Windows.Forms.ToolStripMenuItem separador1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gRUPODEUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPODECHAMADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deligarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.sP_BuscarOSAbertaTableAdapter = new UIPrincipal.ORDEMSERVICODataSetTableAdapters.SP_BuscarOSAbertaTableAdapter();
            separador1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSAbertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuscarOSAbertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDEMSERVICODataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // separador1
            // 
            separador1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            separador1.Enabled = false;
            separador1.ForeColor = System.Drawing.Color.Black;
            separador1.Name = "separador1";
            separador1.ShowShortcutKeys = false;
            separador1.Size = new System.Drawing.Size(22, 23);
            separador1.Text = "|";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRUPODEUSUARIOToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.aJUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gRUPODEUSUARIOToolStripMenuItem
            // 
            this.gRUPODEUSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.tIPODECHAMADOToolStripMenuItem,
            this.pLANOToolStripMenuItem});
            this.gRUPODEUSUARIOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.ferramentasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ferramentasToolStripMenuItem.Text = "&FERRAMENTAS";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.personalizarToolStripMenuItem.Text = "PERSONALIZAR";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.opçõesToolStripMenuItem.Text = "OPÇÕES";
            // 
            // aJUDAToolStripMenuItem
            // 
            this.aJUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOBREToolStripMenuItem,
            this.sAIRToolStripMenuItem,
            this.deligarToolStripMenuItem});
            this.aJUDAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            this.aJUDAToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aJUDAToolStripMenuItem.Text = "&AJUDA";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sOBREToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sOBREToolStripMenuItem.Text = "&SOBRE";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sAIRToolStripMenuItem.Text = "&LOGOFF";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // deligarToolStripMenuItem
            // 
            this.deligarToolStripMenuItem.Name = "deligarToolStripMenuItem";
            this.deligarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deligarToolStripMenuItem.Text = "DESLIGAR";
            this.deligarToolStripMenuItem.Click += new System.EventHandler(this.deligarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuario,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuario
            // 
            this.toolStripStatusLabelUsuario.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            this.toolStripStatusLabelUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabelUsuario.Text = "USUARIO";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = " :LOGADO COMO";
            // 
            // panelCentro
            // 
            this.panelCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentro.BackColor = System.Drawing.Color.Black;
            this.panelCentro.Controls.Add(this.dataGridViewOSAbertas);
            this.panelCentro.Controls.Add(this.menuStrip2);
            this.panelCentro.Location = new System.Drawing.Point(0, 27);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(854, 551);
            this.panelCentro.TabIndex = 3;
            // 
            // dataGridViewOSAbertas
            // 
            this.dataGridViewOSAbertas.AllowUserToResizeColumns = false;
            this.dataGridViewOSAbertas.AllowUserToResizeRows = false;
            this.dataGridViewOSAbertas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewOSAbertas.AutoGenerateColumns = false;
            this.dataGridViewOSAbertas.BackgroundColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOSAbertas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOSAbertas.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewOSAbertas.MaximumSize = new System.Drawing.Size(830, 600);
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
            this.dataGridViewOSAbertas.Size = new System.Drawing.Size(830, 514);
            this.dataGridViewOSAbertas.TabIndex = 3;
            this.dataGridViewOSAbertas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOSAbertas_CellClick);
            this.dataGridViewOSAbertas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOSAbertas_CellDoubleClick);
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
            this.nomeCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
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
            this.dataPrazoDataGridViewTextBoxColumn.DataPropertyName = "DataPrazo";
            this.dataPrazoDataGridViewTextBoxColumn.HeaderText = "Prazo";
            this.dataPrazoDataGridViewTextBoxColumn.Name = "dataPrazoDataGridViewTextBoxColumn";
            this.dataPrazoDataGridViewTextBoxColumn.Width = 70;
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
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNovo,
            separador1,
            this.imprimirToolStripMenuItem,
            this.visualizarImpressãoToolStripMenuItem,
            this.toolStripTextBoxPesquisar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 2, 0, 6);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(854, 31);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItemNovo
            // 
            this.toolStripMenuItemNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemNovo.Image")));
            this.toolStripMenuItemNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItemNovo.Name = "toolStripMenuItemNovo";
            this.toolStripMenuItemNovo.Size = new System.Drawing.Size(28, 23);
            this.toolStripMenuItemNovo.Text = "&Novo";
            this.toolStripMenuItemNovo.ToolTipText = "Nova O.S";
            this.toolStripMenuItemNovo.Click += new System.EventHandler(this.toolStripMenuItemNovo_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            this.imprimirToolStripMenuItem.ToolTipText = "Imprimir O.S";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            this.visualizarImpressãoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.visualizarImpressãoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visualizarImpressãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarImpressãoToolStripMenuItem.Image")));
            this.visualizarImpressãoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            this.visualizarImpressãoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.visualizarImpressãoToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.visualizarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(40, 23);
            this.visualizarImpressãoToolStripMenuItem.Text = "Visuali&zar Impressão";
            this.visualizarImpressãoToolStripMenuItem.ToolTipText = "Pesquisar O.S";
            this.visualizarImpressãoToolStripMenuItem.Click += new System.EventHandler(this.visualizarImpressãoToolStripMenuItem_Click);
            // 
            // toolStripTextBoxPesquisar
            // 
            this.toolStripTextBoxPesquisar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxPesquisar.BackColor = System.Drawing.Color.White;
            this.toolStripTextBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBoxPesquisar.MaxLength = 14;
            this.toolStripTextBoxPesquisar.Name = "toolStripTextBoxPesquisar";
            this.toolStripTextBoxPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBoxPesquisar.Size = new System.Drawing.Size(150, 23);
            // 
            // sP_BuscarOSAbertaTableAdapter
            // 
            this.sP_BuscarOSAbertaTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(854, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA O.S";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSAbertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuscarOSAbertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDEMSERVICODataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem pLANOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPODECHAMADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.BindingSource sPBuscarOSAbertaBindingSource;
        private ORDEMSERVICODataSet oRDEMSERVICODataSet;
        private ORDEMSERVICODataSetTableAdapters.SP_BuscarOSAbertaTableAdapter sP_BuscarOSAbertaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewOSAbertas;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNovo;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPesquisar;
        private System.Windows.Forms.ToolStripMenuItem deligarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrazoDataGridViewTextBoxColumn;
    }
}