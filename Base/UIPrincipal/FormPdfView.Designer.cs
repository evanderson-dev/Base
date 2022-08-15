namespace UIPrincipal
{
    partial class FormPdfView
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
            this.buttonAbrirPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbrirPDF
            // 
            this.buttonAbrirPDF.Location = new System.Drawing.Point(767, 12);
            this.buttonAbrirPDF.Name = "buttonAbrirPDF";
            this.buttonAbrirPDF.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrirPDF.TabIndex = 0;
            this.buttonAbrirPDF.Text = "ABRIR PDF";
            this.buttonAbrirPDF.UseVisualStyleBackColor = true;
            this.buttonAbrirPDF.Click += new System.EventHandler(this.buttonAbrirPDF_Click);
            // 
            // FormPdfView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.buttonAbrirPDF);
            this.Name = "FormPdfView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrirPDF;
    }
}