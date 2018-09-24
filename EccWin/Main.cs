using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EccWin.Encontros;
using EccWin.Inscricao;

namespace EccWin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar aplicativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void encontroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoEncontro ne = new NovoEncontro();
            ne.MdiParent = this;
            ne.Show();
        }

        private void préInscriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscricao ni = new frmInscricao();
            ni.MdiParent = this;
            ni.Show();
        }

        private void encontrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaEncontro be = new BuscaEncontro();
            be.MdiParent = this;
            be.Show();
        }

        private void casaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaInscricao ni = new BuscaInscricao();
            ni.MdiParent = this;
            ni.Show();
        }
    }
}
