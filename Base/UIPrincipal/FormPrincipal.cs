using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                    Application.Exit();
            }
        }
        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaUsuario frm = new FormConsultaUsuario())
            {
                frm.ShowDialog();
            }
        }
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void pLANOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaPlano frm = new FormConsultaPlano())
            {
                frm.ShowDialog();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta =  MessageBox.Show("DESEJA ENCERRAR O SISTEMA?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                //
            }
        }
    }
}
