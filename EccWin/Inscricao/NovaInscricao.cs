using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using EccDomain;
using EccCross.ViewModel.Request;

namespace EccWin.Inscricao
{
    public partial class frmInscricao : Form
    {
        public frmInscricao()
        {
            InitializeComponent();
        }

        private InscricaoRequestViewModel request;

        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;
        private bool TelaPronta = false;
        private string[] UF = new string[]{ "--","AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT",
                                "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS",
                                "RO", "RR", "SC", "SP", "SE", "TO" };

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Deseja Fechar o cadastro?", "Cancelar nova inscrição", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
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
            throw new NotImplementedException();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Valida encontro
            if (cboEvento.SelectedIndex < 1)
            {
                MessageBox.Show("Selecione um evento", "Informação faltando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            request.Casal = GravaCasal();
            request.FilhosSolteiros = gridFilhoSolteiro.DataSource as List<FilhosSolteirosRequestViewModel>;
            request.Cuidadores = GravaCuidadores();
            request.FilhosCasados = gridFilhoCasado.DataSource as List<FilhosCasadosRequestViewModel>;
            request.CasalConvidador = GravaCasalConvidador();

            request.IdEncontro = Convert.ToInt16(cboEvento.SelectedValue);
            request.Participou = false;

            GravaInscricao(request);



            pnlResultado.Visible = true;
        }

        private void GravaInscricao(InscricaoRequestViewModel request)
        {
            //request.IdCasal = request.Casal.CasalId;
            //request.IdCasalConvidador = request.CasalConvidador.IdCasalConvidador;
            //request.IdCasalVisitador = request.CasalVisitador.IdCasalVisitador;

            EccDomain.Inscricao ins = new EccDomain.Inscricao();
            ins.GravarInscricao(request);
        }

        private CasaisConvidadoresRequestViewModel GravaCasalConvidador()
        {
            //gravação de objeto
            return new CasaisConvidadoresRequestViewModel
            {
                NomeEle = !string.IsNullOrEmpty(txtELEConvite.Text) ? txtELEConvite.Text : string.Empty,
                NomeEla = !string.IsNullOrEmpty(txtELAConvite.Text) ? txtELAConvite.Text : string.Empty,
                CelularEle = !string.IsNullOrEmpty(txtELEConviteCel.Text) ? txtELEConviteCel.Text : string.Empty,
                CelularEla = !string.IsNullOrEmpty(txtELAConviteCel.Text) ? txtELAConviteCel.Text : string.Empty,
                EmailEle = !string.IsNullOrEmpty(txtELEConviteMail.Text) ? txtELEConviteMail.Text : string.Empty,
                EmailEla = !string.IsNullOrEmpty(txtELAConviteMail.Text) ? txtELAConviteMail.Text : string.Empty,
                IgrejaEle = !string.IsNullOrEmpty(txtELEIgreja.Text) ? txtELEIgreja.Text : string.Empty,
                IgrejaEla = !string.IsNullOrEmpty(txtELAIgreja.Text) ? txtELAIgreja.Text : string.Empty,
                Equipe = !string.IsNullOrEmpty(txtEquipeTrabalho.Text) ? txtEquipeTrabalho.Text : string.Empty,
            };
        }

        private CuidadoresRequestViewModel GravaCuidadores()
        {
            return new CuidadoresRequestViewModel
            {
                Nome = !string.IsNullOrEmpty(txtCuidador.Text) ? txtCuidador.Text : string.Empty,
                Parentesco = !string.IsNullOrEmpty(txtCuidadorParentesco.Text) ? txtCuidadorParentesco.Text : string.Empty,
                Fone = !string.IsNullOrEmpty(txtCuidadorTelefone.Text) ? txtCuidadorTelefone.Text : string.Empty,
                Endereco = !string.IsNullOrEmpty(txtCuidadorEndereco.Text) ? txtCuidadorEndereco.Text : string.Empty,
                PontoReferencia = !string.IsNullOrEmpty(txtPontoReferencia.Text) ? txtPontoReferencia.Text : string.Empty,
            };
        }

        private CasalRequestViewModel GravaCasal()
        {
            return new CasalRequestViewModel
            {
                NomeEle = txtELENome.Text,
                NomeEla = txtELANome.Text,
                ReligiaoEle = txtELEReligiao.Text,
                ReligiaoEla = txtELAReligiao.Text,
                DtNascimentoEle = dtpELENascimento.Value,
                DtNascimentoEla = dtpELANascimento.Value,
                //EstadoCivil  = .Text,
                //DtEstadoCivil  = item.Text,
                Endereco = txtLogradouro.Text,
                CEP = txtCEP.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                UF = cboUf.SelectedItem.ToString(),
                TelResidencial = txtTelResid.Text,
                CelularEle = txtELECelular.Text,
                CelularEla = txtELACelular.Text,
                EmailEle = txtELEEmail.Text,
                EmailEla = txtELAEmail.Text,
                ProfissaoEle = txtELEProfissao.Text,
                ProfissaoEla = txtELAProfissao.Text,
                LocalTrabalhoEle = txtELELocalDeTrabalho.Text,
                LocalTrabalhoEla = txtELALocalDeTrabalho.Text,
                CidadeTrabalhoEle = txtELECidade.Text,
                CidadeTrabalhoEla = txtELACidade.Text,
                PaiEle = txtELEPai.Text,
                MaeEle = txtELEMae.Text,
                EnderecoPaisEle = txtELELogradouroPais.Text,
                NumeroPaisEle = txtELENumero.Text,
                BairroPaisEle = txtELEBairro.Text,
                CidadePaisEle = txtELECidadePais.Text,
                UFPaisEle = cboELEUF.SelectedItem.ToString(),
                CEPPaisEle = txtELECEP.Text,
                TelResPaisEle = txtELETelResid.Text,
                TelCelPaisEle = txtELECelularPais.Text,
                PaiEla = txtELAPai.Text,
                MaeEla = txtELAMae.Text,
                EnderecoPaisEla = txtELALogradouroPais.Text,
                NumeroPaisEla = txtELANumero.Text,
                BairroPaisEla = txtELABairro.Text,
                CidadePaisEla = txtELACidadePais.Text,
                UFPaisEla = cboELAUF.SelectedItem.ToString(),
                CEPPaisEla = txtELACEP.Text,
                TelResPaisEla = txtELATelResid.Text,
                TelCelPaisEla = txtELACelularPais.Text
            };
        }

        private void NovaInscricao_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor

            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);// specified web cam and its filter moniker string
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 

            CarregaComboEvento();
            CarregaEstado();
            CarregaIdade();
            TelaPronta = true;
            gridFilhoSolteiro.AutoGenerateColumns = false;
            gridFilhoCasado.AutoGenerateColumns = false;
            request = new InscricaoRequestViewModel();
        }

        private void CarregaIdade()
        {
            for (int i = 0; i <= 80; i++)
            {
                cboIdade.Items.Add(i.ToString());
            }
        }

        private void CarregaEstado()
        {
            cboELAUF.Items.AddRange(UF);
            cboELEUF.Items.AddRange(UF);
            cboUf.Items.AddRange(UF);

            cboELEUF.SelectedIndex = cboELAUF.SelectedIndex = cboUf.SelectedIndex = 0;
        }

        private void CarregaComboEvento()
        {
            Encontro ev = new Encontro();
            var lista = ev.GetAll().Where(x => x.EventoRealizado == false).ToList();
            lista.Insert(0, new EccCross.ViewModel.Response.EncontroResponseViewModel { EncontroId = 0, Nome = "-- Selecione --" });
            cboEvento.DisplayMember = "Nome";
            cboEvento.ValueMember = "EncontroId";
            cboEvento.DataSource = lista;

        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
        // New Frame Event Args is an constructor of a class
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            FinalFrame.Start();
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //Save First
                Bitmap varBmp = new Bitmap(pictureBox1.Image);
                Bitmap newBitmap = new Bitmap(varBmp);
                varBmp.Save(@"C:\apoio\a.png", ImageFormat.Png);
                //Now Dispose to free the memory
                varBmp.Dispose();
                varBmp = null;
                if (FinalFrame.IsRunning == true) FinalFrame.Stop();
                pictureBox1.ImageLocation = @"C:\apoio\a.png";
            }
            else
            { MessageBox.Show("null exception"); }
        }

        private void cboEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TelaPronta)
                return;
            if (cboEvento.SelectedIndex == 0)
            {
                lblDataInicial.Text = "--";
                lblDataFinal.Text = "--";
                lblLocal.Text = "--";
                return;
            }
            Encontro ev = new Encontro();
            var evento = ev.GetById((int)cboEvento.SelectedValue);
            lblDataInicial.Text = evento.DtInicial.Value.ToShortDateString();
            lblDataFinal.Text = evento.DtFinal.Value.ToShortDateString();
            lblLocal.Text = evento.Local;

        }


        private List<FilhosSolteirosRequestViewModel> listaFilhoSolteiro;
        private void btnAddFilhoSolteiro_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeFilho.Text))
            {
                MessageBox.Show("Preencha o nome do filho solteiro", "Informação faltando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listaFilhoSolteiro == null)
                listaFilhoSolteiro = new List<FilhosSolteirosRequestViewModel>();

            listaFilhoSolteiro.Add(new FilhosSolteirosRequestViewModel
            {
                Nome = txtNomeFilho.Text,
                Idade = cboIdade.Text
            });

            txtNomeFilho.Text = string.Empty;
            cboIdade.SelectedIndex = 0;

            gridFilhoSolteiro.DataSource = null;
            gridFilhoSolteiro.DataSource = listaFilhoSolteiro;
        }

        private List<FilhosCasadosRequestViewModel> listaFilhoCasado;
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFilhoCasado.Text))
            {
                MessageBox.Show("Preencha o nome do filho casado", "Informação faltando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtTelefone.Text.Replace("(", "")
                .Replace(")", "").Replace("-", "").Trim()))
            {
                MessageBox.Show("Preencha o telefone", "Informação faltando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtEnderecoFilho.Text))
            {
                MessageBox.Show("Preencha o endereço", "Informação faltando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listaFilhoCasado == null)
                listaFilhoCasado = new List<FilhosCasadosRequestViewModel>();

            listaFilhoCasado.Add(new FilhosCasadosRequestViewModel
            {
                Nome = txtFilhoCasado.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEnderecoFilho.Text
            });

            gridFilhoCasado.DataSource = null;
            gridFilhoCasado.DataSource = listaFilhoCasado;

            txtFilhoCasado.Clear();
            txtEnderecoFilho.Clear();
            txtTelefone.Clear();
        }
    }
}
