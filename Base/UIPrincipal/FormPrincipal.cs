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

        private void gRUPODEUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = !this.Visible;
            using (FormConsultaUsuario frm = new FormConsultaUsuario())
            {
                frm.ShowDialog();
            }
            //this.Visible = !this.Visible;
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
