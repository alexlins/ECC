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
    public partial class BuscaEncontro : Form
    {
        private bool _incluirData;
        public BuscaEncontro()
        {
            InitializeComponent();
            _incluirData = chkIncluirData.Checked;
            atualizaDatas();
        }

        private void chkIncluirData_CheckedChanged(object sender, EventArgs e)
        {
            _incluirData = chkIncluirData.Checked;
            atualizaDatas();
        }

        private void atualizaDatas()
        {
            dtpInicial.Enabled = dtpFinal.Enabled = _incluirData;

            if (_incluirData)
                dtpInicial.Value = dtpFinal.Value = DateTime.Now;
            else
                dtpInicial.Value = dtpFinal.Value = new DateTime(1900, 1, 1);

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Popular Filtro
            EncontroRequestViewModel filtro = new EncontroRequestViewModel();
            filtro.Nome = txtCodigo.Text;
            filtro.Local = txtLocal.Text;
            if (_incluirData)
            {
                filtro.DtInicial = dtpInicial.Value;
                filtro.DtFinal = dtpFinal.Value;
            }

            List<EncontroResponseViewModel> lista = new Encontro().GetEncontroByFilter(filtro);

            if (lista.Count > 0)
            {
                lblResultado.Visible = false;
                grdResultado.DataSource = lista;
                grdResultado.Visible = true;
            }
            else
            {
                grdResultado.Visible = false;
                lblResultado.Visible = true;
            }
        }
    }
}
