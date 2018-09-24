using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Request;
using EccCross.ViewModel.Response;

namespace EccDomain
{
    public class Inscricao
    {
        private EccInfra.Repository.CasalRepository _infraCasal;
        private EccInfra.Repository.CasaisConvidadoresRepository _infraCasaisConvidadores;
        private EccInfra.Repository.CasalVisitadorRepository _infraCasalVisitador;
        private EccInfra.Repository.CuidadoresRepository _infraCuidadores;
        private EccInfra.Repository.FilhosCasadosRepository _infraFilhosCasados;
        private EccInfra.Repository.FilhosSolteirosRepository _infraFilhosSolteiros;
        private EccInfra.Repository.InscricoesRepository _infraInscricoes;

        public Inscricao()
        {
            _infraCasal = new EccInfra.Repository.CasalRepository();
            _infraCasaisConvidadores = new EccInfra.Repository.CasaisConvidadoresRepository();
            _infraCasalVisitador = new EccInfra.Repository.CasalVisitadorRepository();
            _infraCuidadores = new EccInfra.Repository.CuidadoresRepository();
            _infraFilhosCasados = new EccInfra.Repository.FilhosCasadosRepository();
            _infraFilhosSolteiros = new EccInfra.Repository.FilhosSolteirosRepository();
            _infraInscricoes = new EccInfra.Repository.InscricoesRepository();
        }

        public bool GravarInscricao(InscricaoRequestViewModel viewModel)
        {
            //grava casal

            var casal = _infraCasal.AddOrUpdate(viewModel.Casal);
            if (casal == null)
                return false;
            var IdCasal = casal.CasalId;

            //grava filhos Solteiros
            if (viewModel.FilhosSolteiros.Any())
                _infraFilhosSolteiros.AddOrUpdateList(viewModel.FilhosSolteiros, IdCasal);

            //grava Cuidador
            if (viewModel.Cuidadores != null)
            {
                viewModel.Cuidadores.CasalId = IdCasal;
                _infraCuidadores.AddOrUpdate(viewModel.Cuidadores);
            }

            //grava Filhos Casados
            if (viewModel.FilhosCasados.Any())
                _infraFilhosCasados.AddOrUpdateList(viewModel.FilhosCasados, IdCasal);

            CasaisConvidadoresResponseViewModel casalConvidador = null;
            //grava Casal Convidador
            if (viewModel.CasalConvidador != null)
                casalConvidador = _infraCasaisConvidadores.AddOrUpdate(viewModel.CasalConvidador);


            //grava casal Visitador
            CasalVisitadorResponseViewModel casalVisitador = null;
            if (viewModel.CasalVisitador != null)
                casalVisitador = _infraCasalVisitador.AddOrUpdate(viewModel.CasalVisitador);

            //grava inscricao
            viewModel.IdCasal = IdCasal;
            viewModel.IdCasalConvidador = casalConvidador!= null? casalConvidador.IdCasalConvidador:0;
            viewModel.IdCasalVisitador = casalVisitador!= null? casalVisitador.IdCasalVisitador:0;

            var retorno = _infraInscricoes.AddOrUpdate(viewModel);

            if (retorno == null || retorno.IdInscricao == 0)
                return false;

            return true;
        }

        public List<InscricaoResponseViewModel> GetAll()
        {
            return _infraInscricoes.GetAll();
        }


        public List<InscricaoResponseViewModel> GetByFilter(InscricaoRequestViewModel filter)
        {
            List<InscricaoResponseViewModel> retorno = new List<InscricaoResponseViewModel>();
            if (filter.IdEncontro != 0)
            {
                retorno = _infraInscricoes.GetByEncontroId(filter.IdEncontro);
                if (!retorno.Any())
                    return retorno;
            }

            if (filter.Casal != null)
            {
                if (!String.IsNullOrEmpty(filter.Casal.NomeEle))
                {
                    if (retorno.Any())
                        retorno = retorno.Where(x => x.Casal.NomeEle.Contains(filter.Casal.NomeEle)).ToList();
                    retorno = _infraInscricoes.GetByCasalEleNome(filter.Casal.NomeEle);
                }

                if (!String.IsNullOrEmpty(filter.Casal.NomeEla))
                {
                    if (retorno.Any())
                        retorno = retorno.Where(x => x.Casal.NomeEla.Contains(filter.Casal.NomeEla)).ToList();
                    retorno = _infraInscricoes.GetByCasalElaNome(filter.Casal.NomeEla);
                }
            }

            return retorno;
        }
    }
}
