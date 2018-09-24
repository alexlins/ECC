using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Response;
using EccCross.ViewModel.Request;

namespace EccInfra.Repository
{
    public class CuidadoresRepository
    {
        private EccEntities _entity;
        public CuidadoresRepository()
        {
            _entity = new EccEntities();
        }

        public List<CuidadoresResponseViewModel> GetAll()
        {
            var listaCuidadores = _entity.Cuidadores.ToList();

            if (listaCuidadores.Count == 0)
                return new List<CuidadoresResponseViewModel>();

            List<CuidadoresResponseViewModel> resultado = new List<CuidadoresResponseViewModel>();

            foreach (var item in listaCuidadores)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public CuidadoresResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.Cuidadores.Where(x => x.CuidadorId == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new CuidadoresResponseViewModel();
            }
        }

        public CuidadoresResponseViewModel AddOrUpdate(CuidadoresRequestViewModel item)
        {
            Cuidadores ee;
            if (item.CuidadorId == 0)
                ee = new Cuidadores();
            else
            {
                ee = _entity.Cuidadores.Where(x => x.CuidadorId == item.CuidadorId).FirstOrDefault();
                if (ee.CuidadorId == 0)
                    return new CuidadoresResponseViewModel();
            }

            ee.CasalId = item.CasalId;
            ee.Nome = item.Nome;
            ee.Parentesco = item.Parentesco;
            ee.Fone = item.Fone;
            ee.Endereco = item.Endereco;
            ee.PontoReferencia = item.PontoReferencia;

            if (ee.CuidadorId == 0)
            {
                var ultimo = _entity.Cuidadores.OrderByDescending(o => o.CuidadorId).ToList();
                if (ultimo.Any())
                    ee.CuidadorId = ultimo[0].CuidadorId + 1;
                else
                    ee.CuidadorId = 1;
                _entity.AddObject("Cuidadores", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        private CuidadoresResponseViewModel MontaViewModel(Cuidadores item)
        {
            return new CuidadoresResponseViewModel
            {
                CuidadorId = item.CuidadorId,
                CasalId = item.CasalId,
                Nome = item.Nome,
                Parentesco = item.Parentesco,
                Fone = item.Fone,
                Endereço = item.Endereco,
                PontoReferencia = item.PontoReferencia
            };
        }

    }
}
