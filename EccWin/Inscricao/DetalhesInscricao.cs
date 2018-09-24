using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EccCross.ViewModel.Response;

namespace EccWin.Inscricao
{
    public partial class DetalhesInscricao : Form
    {
        private InscricaoGridResultViewModel _inscricao;
        public DetalhesInscricao(InscricaoGridResultViewModel inscricao)
        {
            InitializeComponent();
            _inscricao = inscricao;
        }

        private void DetalhesInscricao_Load(object sender, EventArgs e)
        {
            CarregaDetalhes(_inscricao);
        }

        private void CarregaDetalhes(InscricaoGridResultViewModel _inscricao)
        {
            lblParticipou.Text = _inscricao.Participou.ToUpper() == "S" ? "Sim" : "Não";
            CarregaEvento(_inscricao.Encontro);
            CarregaCasal(_inscricao.Casal);
        }

        private void CarregaCasal(CasalResponseViewModel casal)
        {
            lblNomeELE.Text = casal.NomeEle;
            lblNomeELA.Text = casal.NomeEla;
            lblCelularELE.Text = casal.CelularEle;
            lblCelularELA.Text = casal.CelularEla;
        }

        private void CarregaEvento(EncontroResponseViewModel evento)
        {
            lblEvento.Text = evento.Nome;
            lblDataInicial.Text = ((DateTime)evento.DtInicial).ToShortDateString();
            lblDataFinal.Text = ((DateTime)evento.DtFinal).ToShortDateString();
            lblLocal.Text = evento.Local;
        }
    }
}
