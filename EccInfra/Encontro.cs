using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel;

namespace EccInfra
{
    public class Encontro
    {
        private EccEntities _entity;
        public Encontro()
        {
            _entity = new EccEntities();
        }

        public List<EncontroResponseViewModel> GetAll()
        {
            var listaEncontros = _entity.Encontros.ToList();

            if (listaEncontros.Count == 0)
                return new List<EncontroResponseViewModel>();

            List<EncontroResponseViewModel> resultado = new List<EncontroResponseViewModel>();

            foreach (var item in listaEncontros)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        private static EncontroResponseViewModel MontaViewModel(Encontros item)
        {
            return new EncontroResponseViewModel
            {
                EncontroId = item.EncontroId,
                Local = item.Local,
                Nome = item.Nome,
                DtInicial = item.DtInicial,
                DtFinal = item.DtFinal,
                EventoConfirmado = item.EventoConfirmado,
                EventoRealizado = item.EventoRealizado,
                QtdeCasais = item.QtdeCasais
            };
        }


        public EncontroResponseViewModel AddOrUpdate(EncontroRequestViewModel item)
        {
            Encontros ee;
            if (item.EncontroId == 0)
                ee = new Encontros();
            else
            {
                ee = _entity.Encontros.Where(x => x.EncontroId == item.EncontroId).FirstOrDefault();
                if (ee.EncontroId == 0)
                    return new EncontroResponseViewModel();
            }

            ee.Local = item.Local;
            ee.Nome = item.Nome;
            ee.DtInicial = item.DtInicial;
            ee.DtFinal = item.DtFinal;
            ee.EventoConfirmado = item.EventoConfirmado;
            ee.EventoRealizado = item.EventoRealizado;
            ee.QtdeCasais = item.QtdeCasais;

            if (ee.EncontroId == 0)
            {
                var ultimo = _entity.Encontros.OrderByDescending(o => o.EncontroId).ToList();
                ee.EncontroId = ultimo[0].EncontroId + 1;
                _entity.AddObject("Encontros", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        public EncontroResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.Encontros.Where(x => x.EncontroId == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new EncontroResponseViewModel();
            }
        }
    }
}
