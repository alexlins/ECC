using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EccCross.ViewModel;
using EccDomain;

namespace EccWin.Encontros
{
    public partial class NovoEncontro : Form
    {
        Encontro _encontro;
        public NovoEncontro()
        {
            InitializeComponent();
            dtpInicial.Value = dtpFinal.Value = DateTime.Now;
            _encontro = new Encontro();
        }

        private void NovoEncontro_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 300; i++)
                cboQtde.Items.Add(i.ToString());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Deseja Fechar o cadastro?", "Cancelar novo Encontro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    this.Close();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    if (MessageBox.Show("Deseja apagar o cadastro?", "Apagar campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        ClearForm();
                    break;
                default:
                    break;
            }
        }

        private void ClearForm()
        {
            txtNome.Text = "";
            txtLocal.Text = "";
            dtpInicial.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Validar os campos
            bool valido = ValidaCampos();
            if (!valido)
            {
                lblResultado.Text = "Preencha corretamente os campos";
            }
            else
            {
                EncontroRequestViewModel ervm = new EncontroRequestViewModel();
                ervm.Nome = txtNome.Text;
                ervm.Local = txtLocal.Text;
                ervm.DtInicial = dtpInicial.Value;
                ervm.DtFinal = dtpFinal.Value;
                ervm.QtdeCasais = Convert.ToInt16(cboQtde.Text);
                ervm.EventoConfirmado = chkConfirmado.Checked;
                ervm.EventoRealizado = chkRealizado.Checked;

                if (_encontro.GravarEncontro(ervm))
                    lblResultado.Text = "Gravado com sucesso";
                else
                    lblResultado.Text = "Erro na gravação";
            }
            pnlResultado.Visible = true;
        }

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
                return false;

            if (String.IsNullOrEmpty(txtLocal.Text))
                return false;

            int fake = 0;
            if (!int.TryParse(cboQtde.Text, out fake))
                return false;


            return true;

        }
    }
}
