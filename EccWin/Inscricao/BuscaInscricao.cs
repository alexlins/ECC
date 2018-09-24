using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EccDomain;
using EccCross.ViewModel.Response;
using EccCross.ViewModel.Request;

namespace EccWin.Inscricao
{
    public partial class BuscaInscricao : Form
    {
        public BuscaInscricao()
        {
            InitializeComponent();
        }

        private void BuscaInscricao_Load(object sender, EventArgs e)
        {
            CarregaComboEvento();
            gridResultado.AutoGenerateColumns = false;
        }

        private void CarregaComboEvento()
        {
            Encontro ev = new Encontro();
            var lista = ev.GetAll().ToList();
            lista.Insert(0, new EccCross.ViewModel.Response.EncontroResponseViewModel { EncontroId = 0, Nome = "-- Selecione --" });
            cboEvento.DisplayMember = "Nome";
            cboEvento.ValueMember = "EncontroId";
            cboEvento.DataSource = lista;

        }

        private void btnProcurarInscrição_Click(object sender, EventArgs e)
        {
            InscricaoRequestViewModel filtro = null;
            if (cboEvento.SelectedIndex != 0)
            {
                filtro = new InscricaoRequestViewModel();
                filtro.IdEncontro = (int)cboEvento.SelectedValue;
            }

            if (!string.IsNullOrEmpty(txtELEBusca.Text))
            {
                if (filtro == null)
                    filtro = new InscricaoRequestViewModel();
                if (filtro.Casal == null)
                    filtro.Casal = new CasalRequestViewModel();
                filtro.Casal.NomeEle = txtELEBusca.Text;
            }

            if (!string.IsNullOrEmpty(txtELABusca.Text))
            {
                if (filtro == null)
                    filtro = new InscricaoRequestViewModel();
                if (filtro.Casal == null)
                    filtro.Casal = new CasalRequestViewModel();
                filtro.Casal.NomeEla = txtELABusca.Text;
            }

            EccDomain.Inscricao insc = new EccDomain.Inscricao();
            var lista = filtro == null ? insc.GetAll() : insc.GetByFilter(filtro);
            List<InscricaoGridResultViewModel> ListaResultado = new List<InscricaoGridResultViewModel>();
            lista.ForEach(x =>
            {
                var item = new InscricaoGridResultViewModel();
                item.Casal = x.Casal;
                item.Convidador = x.Convidador;
                item.Encontro = x.Encontro;
                item.IdCasal = x.IdCasal;
                item.IdCasalConvidador = x.IdCasalConvidador;
                item.IdCasalVisitador = x.IdCasalVisitador;
                item.IdEncontro = x.IdEncontro;
                item.IdInscricao = x.IdInscricao;
                item.ListaVisitadores = x.ListaVisitadores;
                item.NomeEle = x.Casal.NomeEle;
                item.NomeEla = x.Casal.NomeEla;
                item.NomeEncontro = x.Encontro.Nome;
                item.Participou = x.Participou ? "Sim" : "Não";
                ListaResultado.Add(item);
            });

            gridResultado.DataSource = null;
            gridResultado.DataSource = ListaResultado;

            gridResultado.Visible = ListaResultado.Any();
            lblResultado.Visible = !ListaResultado.Any();

        }

        private void gridResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataValue = gridResultado.Rows[e.RowIndex].DataBoundItem as InscricaoGridResultViewModel;
            DetalhesInscricao det = new DetalhesInscricao(dataValue);
            det.ShowDialog();
        }
    }

    public class InscricaoGridResultViewModel : InscricaoResponseViewModel
    {
        public string NomeEle { get; set; }
        public string NomeEla { get; set; }
        public string NomeEncontro { get; set; }
        public string Participou { get; set; }

    }
}
