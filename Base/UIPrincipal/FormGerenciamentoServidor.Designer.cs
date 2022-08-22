namespace UIPrincipal
{
    partial class FormGerenciamentoServidor
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.dataGridViewGerenciamentoServidor = new System.Windows.Forms.DataGridView();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stringDeConexaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoServidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoServidorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdicionar.FlatAppearance.BorderSize = 0;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Image = global::UIPrincipal.Properties.Resources.server_add;
            this.buttonAdicionar.Location = new System.Drawing.Point(31, 10);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(23, 23);
            this.buttonAdicionar.TabIndex = 0;
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeletar.FlatAppearance.BorderSize = 0;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.Image = global::UIPrincipal.Properties.Resources.server_delete;
            this.buttonDeletar.Location = new System.Drawing.Point(60, 10);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(23, 23);
            this.buttonDeletar.TabIndex = 1;
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // dataGridViewGerenciamentoServidor
            // 
            this.dataGridViewGerenciamentoServidor.AllowUserToResizeColumns = false;
            this.dataGridViewGerenciamentoServidor.AllowUserToResizeRows = false;
            this.dataGridViewGerenciamentoServidor.AutoGenerateColumns = false;
            this.dataGridViewGerenciamentoServidor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGerenciamentoServidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGerenciamentoServidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.stringDeConexaoDataGridViewTextBoxColumn});
            this.dataGridViewGerenciamentoServidor.DataSource = this.enderecoServidorBindingSource;
            this.dataGridViewGerenciamentoServidor.Location = new System.Drawing.Point(2, 39);
            this.dataGridViewGerenciamentoServidor.Name = "dataGridViewGerenciamentoServidor";
            this.dataGridViewGerenciamentoServidor.RowHeadersVisible = false;
            this.dataGridViewGerenciamentoServidor.Size = new System.Drawing.Size(829, 307);
            this.dataGridViewGerenciamentoServidor.TabIndex = 4;
            this.dataGridViewGerenciamentoServidor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGerenciamentoServidor_CellClick);
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // stringDeConexaoDataGridViewTextBoxColumn
            // 
            this.stringDeConexaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stringDeConexaoDataGridViewTextBoxColumn.DataPropertyName = "StringDeConexao";
            this.stringDeConexaoDataGridViewTextBoxColumn.HeaderText = "Endereço do Servidor";
            this.stringDeConexaoDataGridViewTextBoxColumn.Name = "stringDeConexaoDataGridViewTextBoxColumn";
            // 
            // enderecoServidorBindingSource
            // 
            this.enderecoServidorBindingSource.DataSource = typeof(Model.EnderecoServidor);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = global::UIPrincipal.Properties.Resources.cancel;
            this.buttonSair.Location = new System.Drawing.Point(808, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(23, 23);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtualizar.FlatAppearance.BorderSize = 0;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Image = global::UIPrincipal.Properties.Resources.arrow_refresh;
            this.buttonAtualizar.Location = new System.Drawing.Point(2, 10);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(23, 23);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormGerenciamentoServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 349);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.dataGridViewGerenciamentoServidor);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerenciamentoServidor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIAMENTO DE ENDEREÇO DO SERVIDOR";
            this.Load += new System.EventHandler(this.FormGerenciamentoServidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoServidorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.DataGridView dataGridViewGerenciamentoServidor;
        private System.Windows.Forms.BindingSource enderecoServidorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stringDeConexaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}