﻿using BLL;
using Infra;
using System;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormParaTeste : Form
    {
        public FormParaTeste()
        {
            InitializeComponent();
        }

        private void FormParaTeste_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxCustomizada.Show("TESTE DE MENSAGEM!","");
        }
    }
}
