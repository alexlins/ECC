using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EccDomain;
using EccCross.ViewModel;

namespace EccWin.Encontros
{
    public partial class EncontrosDetalhes : Form
    {
        public int IdEncontro { get; set; }
        Encontro _encontro;
        public EncontrosDetalhes()
        {
            InitializeComponent();
            _encontro = new Encontro();
        }

        private void EncontrosDetalhes_Load(object sender, EventArgs e)
        {
            var viewModel = _encontro.GetById(IdEncontro);

            PopulaTela(viewModel);

        }

        private void PopulaTela(EncontroResponseViewModel viewModel)
        {
            lblNome.Text = viewModel.Nome;
            lblLocal.Text = viewModel.Local;
            lblDtInicial.Text = viewModel.DtInicial.Value.ToShortDateString();
            lblDtFinal.Text = viewModel.DtFinal.Value.ToShortDateString();
            chkConfirmado.Checked = viewModel.EventoConfirmado.Value;
            chkRealizado.Checked = viewModel.EventoRealizado.Value;

            List<InscricaoResponseViewModel> listaInscritos = _encontro.GetInscritos(IdEncontro);

            gridCasais.DataSource = listaInscritos;
            gridCasais.Refresh();

        }
    }
}
