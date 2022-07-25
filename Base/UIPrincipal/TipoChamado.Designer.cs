namespace UIPrincipal
{
    partial class TipoChamado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipoChamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipoChamadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // tipoChamadoBindingSource
            // 
            this.tipoChamadoBindingSource.DataSource = typeof(Model.TipoChamado);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonAlterar);
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 45);
            this.panel1.TabIndex = 1;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.Location = new System.Drawing.Point(689, 4);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(84, 37);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(191, 4);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(85, 37);
            this.buttonExcluir.TabIndex = 6;
            this.buttonExcluir.Text = "E&xcluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(101, 4);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(85, 37);
            this.buttonAlterar.TabIndex = 5;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(12, 4);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(85, 37);
            this.buttonNovo.TabIndex = 4;
            this.buttonNovo.Text = "&Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(212, 70);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(65, 19);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 70);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(196, 20);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // TipoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoChamado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource tipoChamadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}