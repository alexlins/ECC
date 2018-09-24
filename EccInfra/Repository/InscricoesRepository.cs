using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Response;
using EccCross.ViewModel.Request;

namespace EccInfra.Repository
{
    public class InscricoesRepository
    {
        private EccEntities _entity;
        public InscricoesRepository()
        {
            _entity = new EccEntities();
        }

        public List<InscricaoResponseViewModel> GetAll()
        {
            var listaInscricoes = _entity.Inscricoes.ToList();

            if (listaInscricoes.Count == 0)
                return new List<InscricaoResponseViewModel>();

            List<InscricaoResponseViewModel> resultado = new List<InscricaoResponseViewModel>();

            foreach (var item in listaInscricoes)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public InscricaoResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.Inscricoes.Where(x => x.IdInscricao == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new InscricaoResponseViewModel();
            }
        }

        public List<InscricaoResponseViewModel> GetByEncontroId(int id)
        {
            try
            {
                var listaInscricoes = _entity.Inscricoes.Where(x => x.IdEncontro == id).ToList();
                List<InscricaoResponseViewModel> resultado = new List<InscricaoResponseViewModel>();

                foreach (var item in listaInscricoes)
                {
                    resultado.Add(MontaViewModel(item));
                }

                return resultado;
            }
            catch (Exception ex)
            {
                return new List<InscricaoResponseViewModel>();
            }
        }

        public InscricaoResponseViewModel AddOrUpdate(InscricaoRequestViewModel item)
        {
            Inscricoes ee;
            if (item.IdInscricao == 0)
                ee = new Inscricoes();
            else
            {
                ee = _entity.Inscricoes.Where(x => x.IdInscricao == item.IdInscricao).FirstOrDefault();
                if (ee.IdInscricao == 0)
                    return new InscricaoResponseViewModel();
            }

            ee.IdEncontro = item.IdEncontro;
                ee.idCasal = item.IdCasal;
                ee.Participou = item.Participou;
                ee.IdCasalVisitador = item.IdCasalVisitador;
                ee.IdCasalConvidador = item.IdCasalConvidador;

            if (ee.IdInscricao == 0)
            {
                var ultimo = _entity.Inscricoes.OrderByDescending(o => o.IdInscricao).ToList();
                if (ultimo.Any())
                    ee.IdInscricao = ultimo[0].IdInscricao + 1;
                else
                    ee.IdInscricao = 1;
                _entity.AddObject("Inscricoes", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        private InscricaoResponseViewModel MontaViewModel(Inscricoes item)
        {
            return new InscricaoResponseViewModel
            {
                IdInscricao = item.IdInscricao,
                IdEncontro = item.IdEncontro,
                IdCasal = item.idCasal,
                Participou = item.Participou,
                IdCasalVisitador = Convert.ToInt16(item.IdCasalVisitador),
                IdCasalConvidador = Convert.ToInt16(item.IdCasalConvidador),
                Casal = new CasalRepository().GetById(item.idCasal),
                Encontro = new EncontroRepository().GetById(item.IdEncontro),
                ListaVisitadores = new CasalVisitadorRepository().GetByCasalID(item.IdInscricao),
                Convidador = new CasaisConvidadoresRepository().GetById(item.IdCasalConvidador)
            };
        }


        public List<InscricaoResponseViewModel> GetByCasalEleNome(string p)
        {
            var listaCasal = new CasalRepository().GetAll().Where(x => x.NomeEle.Contains(p)).ToList();

            List<InscricaoResponseViewModel> retorno = new List<InscricaoResponseViewModel>();
            
            listaCasal.ForEach(lc =>
            {
                var insc = _entity.Inscricoes.Where(x => x.idCasal == lc.CasalId).ToList();
                if(insc.Any())
                retorno.Add(MontaViewModel(insc.First()));
            });

            return retorno;
        }

        public List<InscricaoResponseViewModel> GetByCasalElaNome(string p)
        {
            var listaCasal = new CasalRepository().GetAll().Where(x => x.NomeEla.Contains(p)).ToList();

            List<InscricaoResponseViewModel> retorno = new List<InscricaoResponseViewModel>();

            listaCasal.ForEach(lc =>
            {
                var insc = _entity.Inscricoes.Where(x => x.idCasal == lc.CasalId).ToList();
                if (insc.Any())
                    retorno.Add(MontaViewModel(insc.First()));
            });

            return retorno;
        }
    }
}
