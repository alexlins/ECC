using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Response;
using EccCross.ViewModel.Request;

namespace EccInfra.Repository
{
    public class FilhosCasadosRepository
    {
        private EccEntities _entity;
        public FilhosCasadosRepository()
        {
            _entity = new EccEntities();
        }

        public List<FilhosCasadosResponseViewModel> GetAll()
        {
            var listaFilhosCasados = _entity.FilhosCasados.ToList();

            if (listaFilhosCasados.Count == 0)
                return new List<FilhosCasadosResponseViewModel>();

            List<FilhosCasadosResponseViewModel> resultado = new List<FilhosCasadosResponseViewModel>();

            foreach (var item in listaFilhosCasados)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public FilhosCasadosResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.FilhosCasados.Where(x => x.FilhoId == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new FilhosCasadosResponseViewModel();
            }
        }

        public FilhosCasadosResponseViewModel AddOrUpdate(FilhosCasadosRequestViewModel item)
        {
            FilhosCasados ee;
            if (item.FilhoId == 0)
                ee = new FilhosCasados();
            else
            {
                ee = _entity.FilhosCasados.Where(x => x.FilhoId == item.FilhoId).FirstOrDefault();
                if (ee.FilhoId == 0)
                    return new FilhosCasadosResponseViewModel();
            }

            ee.CasalId = item.CasalId;
            ee.Endereco = item.Endereco;
            ee.Nome = item.Nome;
            ee.Telefone = item.Telefone;

            if (ee.FilhoId == 0)
            {
                var ultimo = _entity.FilhosCasados.OrderByDescending(o => o.FilhoId).ToList();
                if (ultimo.Any())
                    ee.FilhoId = ultimo[0].FilhoId + 1;
                else
                    ee.FilhoId = 1;
                _entity.AddObject("FilhosCasados", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        private FilhosCasadosResponseViewModel MontaViewModel(FilhosCasados item)
        {
            return new FilhosCasadosResponseViewModel
            {
                FilhoId = item.FilhoId,
                CasalId = item.CasalId,
                Endereco = item.Endereco,
                Nome = item.Nome,
                Telefone = item.Telefone
            };
        }


        public void AddOrUpdateList(List<FilhosCasadosRequestViewModel> list, int IdCasal)
        {
            list.ForEach(x =>
            {
                x.CasalId = IdCasal;
                AddOrUpdate(x);
            });
        }
    }
}
