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
                resultado.Add(new EncontroResponseViewModel
                {
                    EncontroId = item.EncontroId,
                    Local = item.Local,
                    Nome = item.Nome,
                    DtInicial = item.DtInicial,
                    DtFinal = item.DtFinal,
                    EventoConfirmado = item.EventoConfirmado,
                    EventoRealizado = item.EventoRealizado,
                    QtdeCasais = item.QtdeCasais
                });
            }

            return resultado;
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
                _entity.AddObject("Encontros", ee);

            _entity.SaveChanges();

            return new EncontroResponseViewModel()
            {
                EncontroId = ee.EncontroId,
                Local = ee.Local,
                Nome = ee.Nome,
                DtInicial = ee.DtInicial,
                DtFinal = ee.DtFinal,
                EventoConfirmado = ee.EventoConfirmado,
                EventoRealizado = ee.EventoRealizado,
                QtdeCasais = ee.QtdeCasais
            };
        }
    }
}
