using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Response;
using EccCross.ViewModel.Request;

namespace EccInfra.Repository
{
    public class CasaisConvidadoresRepository
    {
        private EccEntities _entity;
        public CasaisConvidadoresRepository()
        {
            _entity = new EccEntities();
        }

        public List<CasaisConvidadoresResponseViewModel> GetAll()
        {
            var listaCasalConvidador = _entity.CasaisConvidadores.ToList();

            if (listaCasalConvidador.Count == 0)
                return new List<CasaisConvidadoresResponseViewModel>();

            List<CasaisConvidadoresResponseViewModel> resultado = new List<CasaisConvidadoresResponseViewModel>();

            foreach (var item in listaCasalConvidador)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public CasaisConvidadoresResponseViewModel GetById(int? id)
        {
            try
            {
                var result = _entity.CasaisConvidadores.Where(x => x.IdCasalConvidador == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new CasaisConvidadoresResponseViewModel();
            }
        }

        public CasaisConvidadoresResponseViewModel AddOrUpdate(CasaisConvidadoresRequestViewModel item)
        {
            CasaisConvidadores ee;
            if (item.IdCasalConvidador == 0)
                ee = new CasaisConvidadores();
            else
            {
                ee = _entity.CasaisConvidadores.Where(x => x.IdCasalConvidador == item.IdCasalConvidador).FirstOrDefault();
                if (ee.IdCasalConvidador == 0)
                    return new CasaisConvidadoresResponseViewModel();
            }

            ee.NomeEle = item.NomeEle;
                ee.NomeEla = item.NomeEla;
                ee.CelularEle = item.CelularEle;
                ee.CelularEla = item.CelularEla;
                ee.EmailEle = item.EmailEle;
                ee.emailEla = item.EmailEla;
                ee.IgrejaEle = item.IgrejaEle;
                ee.IgrejaEla = item.IgrejaEla;
                ee.Equipe = item.Equipe;

            if (ee.IdCasalConvidador == 0)
            {
                var ultimo = _entity.CasaisConvidadores.OrderByDescending(o => o.IdCasalConvidador).ToList();
                if (ultimo.Any())
                    ee.IdCasalConvidador = ultimo[0].IdCasalConvidador + 1;
                else
                    ee.IdCasalConvidador = 1;
                _entity.AddObject("CasaisConvidadores", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        private CasaisConvidadoresResponseViewModel MontaViewModel(CasaisConvidadores item)
        {
            return new CasaisConvidadoresResponseViewModel
            {
                IdCasalConvidador = item.IdCasalConvidador,
                NomeEle = item.NomeEle,
                NomeEla = item.NomeEla,
                CelularEle = item.CelularEle,
                CelularEla = item.CelularEla,
                EmailEle = item.EmailEle,
                EmailEla = item.emailEla,
                IgrejaEle = item.IgrejaEle,
                IgrejaEla = item.IgrejaEla,
                Equipe = item.Equipe
            };
        }

    }
}
