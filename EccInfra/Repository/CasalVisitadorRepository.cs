using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Response;
using EccCross.ViewModel.Request;

namespace EccInfra.Repository
{
    public class CasalVisitadorRepository
    {
        private EccEntities _entity;
        public CasalVisitadorRepository()
        {
            _entity = new EccEntities();
        }

        public List<CasalVisitadorResponseViewModel> GetAll()
        {
            var listaCasalVisitador = _entity.CasaisVisitadores.ToList();

            if (listaCasalVisitador.Count == 0)
                return new List<CasalVisitadorResponseViewModel>();

            List<CasalVisitadorResponseViewModel> resultado = new List<CasalVisitadorResponseViewModel>();

            foreach (var item in listaCasalVisitador)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public CasalVisitadorResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.CasaisVisitadores.Where(x => x.IdCasalVisitador == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new CasalVisitadorResponseViewModel();
            }
        }

        public CasalVisitadorResponseViewModel AddOrUpdate(CasalVisitadorRequestViewModel item)
        {
            CasaisVisitadores ee;
            if (item.IdCasalVisitador == 0)
                ee = new CasaisVisitadores();
            else
            {
                ee = _entity.CasaisVisitadores.Where(x => x.IdCasalVisitador == item.IdCasalVisitador).FirstOrDefault();
                if (ee.IdCasalVisitador == 0)
                    return new CasalVisitadorResponseViewModel();
            }

            ee.NomeEle = item.NomeEle;
            ee.NomeEla = item.NomeEla;
            ee.CelularEle = item.CelularEle;
            ee.CelularEla = item.CelularEla;
            ee.Email = item.Email;
            ee.DtVisita = item.DtVisita;
            ee.Confirmou = item.Confirmou;
            ee.ConducaoPropria = item.ConducaoPropria;
            ee.Equipe = item.Equipe;
            ee.RestricaoAlimentar = item.RestricaoAlimentar;
            ee.ApelidoEle = item.ApelidoEle;
            ee.ApelidoEla = item.ApelidoEla;
            ee.Observacoes = item.Observacoes;
            ee.IdInscricao = item.IdInscricao;

            if (ee.IdCasalVisitador == 0)
            {
                var ultimo = _entity.CasaisVisitadores.OrderByDescending(o => o.IdCasalVisitador).ToList();
                if (ultimo.Any())
                    ee.IdCasalVisitador = ultimo[0].IdCasalVisitador + 1;
                else
                    ee.IdCasalVisitador = 1;
                _entity.AddObject("CasaisVisitadores", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        private CasalVisitadorResponseViewModel MontaViewModel(CasaisVisitadores item)
        {
            return new CasalVisitadorResponseViewModel
            {
                IdCasalVisitador = item.IdCasalVisitador,
                NomeEle = item.NomeEle,
                NomeEla = item.NomeEla,
                CelularEle = item.CelularEle,
                CelularEla = item.CelularEla,
                Email = item.Email,
                DtVisita = item.DtVisita.Value,
                Confirmou = item.Confirmou.Value,
                ConducaoPropria = item.ConducaoPropria.Value,
                Equipe = item.Equipe,
                RestricaoAlimentar = item.RestricaoAlimentar,
                ApelidoEle = item.ApelidoEle,
                ApelidoEla = item.ApelidoEla,
                Observacoes = item.Observacoes,
                IdInscricao = item.IdInscricao.Value
            };
        }


        internal List<CasalVisitadorResponseViewModel> GetByCasalID(int p)
        {
            return GetAll().Where(x => x.IdInscricao == p).ToList();
        }
    }
}
