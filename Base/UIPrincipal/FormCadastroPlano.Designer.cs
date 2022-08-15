
namespace UIPrincipal
{
    partial class FormCadastroPlano
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
            System.Windows.Forms.Label labelDescricao;
            System.Windows.Forms.Label labelValor;
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.planoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelDadosPlano = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            labelDescricao = new System.Windows.Forms.Label();
            labelValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.ForeColor = System.Drawing.Color.White;
            labelDescricao.Location = new System.Drawing.Point(48, 14);
            labelDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new System.Drawing.Size(72, 13);
            labelDescricao.TabIndex = 0;
            labelDescricao.Text = "DESCRIÇÃO:";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.ForeColor = System.Drawing.Color.White;
            labelValor.Location = new System.Drawing.Point(368, 14);
            labelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelValor.Name = "labelValor";
            labelValor.Size = new System.Drawing.Size(46, 13);
            labelValor.TabIndex = 2;
            labelValor.Text = "VALOR:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.Black;
            this.buttonSalvar.Location = new System.Drawing.Point(227, 104);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "SAL&VAR";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.Black;
            this.buttonSair.Location = new System.Drawing.Point(306, 104);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "&SAIR";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // planoBindingSource
            // 
            this.planoBindingSource.DataSource = typeof(Model.Plano);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(51, 29);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(313, 20);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // textBoxValor
            // 
            this.textBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoBindingSource, "Valor", true));
            this.textBoxValor.Location = new System.Drawing.Point(368, 29);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(122, 20);
            this.textBoxValor.TabIndex = 2;
            // 
            // labelDadosPlano
            // 
            this.labelDadosPlano.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDadosPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosPlano.ForeColor = System.Drawing.Color.White;
            this.labelDadosPlano.Location = new System.Drawing.Point(0, 0);
            this.labelDadosPlano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDadosPlano.Name = "labelDadosPlano";
            this.labelDadosPlano.Size = new System.Drawing.Size(606, 34);
            this.labelDadosPlano.TabIndex = 12;
            this.labelDadosPlano.Text = "INSIRA OS DADOS DO NOVO PLANO";
            this.labelDadosPlano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(labelDescricao);
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(labelValor);
            this.groupBox1.Location = new System.Drawing.Point(34, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // FormCadastroPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(606, 133);
            this.Controls.Add(this.labelDadosPlano);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroPlano";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelDadosPlano;
        private System.Windows.Forms.BindingSource planoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

