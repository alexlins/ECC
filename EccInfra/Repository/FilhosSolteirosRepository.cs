using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Request;
using EccCross.ViewModel.Response;

namespace EccInfra.Repository
{
    public class FilhosSolteirosRepository
    {
        private EccEntities _entity;
        public FilhosSolteirosRepository()
        {
            _entity = new EccEntities();
        }

        public List<FilhosSolteirosResponseViewModel> GetAll()
        {
            var listaFilhosSolteiros = _entity.FilhosSolteiros.ToList();

            if (listaFilhosSolteiros.Count == 0)
                return new List<FilhosSolteirosResponseViewModel>();

            List<FilhosSolteirosResponseViewModel> resultado = new List<FilhosSolteirosResponseViewModel>();

            foreach (var item in listaFilhosSolteiros)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public FilhosSolteirosResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.FilhosSolteiros.Where(x => x.FilhoId == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new FilhosSolteirosResponseViewModel();
            }
        }

        public FilhosSolteirosResponseViewModel AddOrUpdate(FilhosSolteirosRequestViewModel item)
        {
            FilhosSolteiros ee;
            if (item.FilhoId == 0)
                ee = new FilhosSolteiros();
            else
            {
                ee = _entity.FilhosSolteiros.Where(x => x.FilhoId == item.FilhoId).FirstOrDefault();
                if (ee.FilhoId == 0)
                    return new FilhosSolteirosResponseViewModel();
            }

            ee.CasalId = item.CasalId;
            ee.Idade = item.Idade;
            ee.Nome = item.Nome;

            if (ee.FilhoId == 0)
            {
                var ultimo = _entity.FilhosSolteiros.OrderByDescending(o => o.FilhoId).ToList();
                if (ultimo.Any())
                    ee.FilhoId = ultimo[0].FilhoId + 1;
                else
                    ee.FilhoId = 1;
                _entity.AddObject("FilhosSolteiros", ee);
            }

            _entity.SaveChanges();

            return MontaViewModel(ee);
        }

        private FilhosSolteirosResponseViewModel MontaViewModel(FilhosSolteiros item)
        {
            return new FilhosSolteirosResponseViewModel
            {
                FilhoId = item.FilhoId,
                CasalId = item.CasalId,
                Idade = item.Idade,
                Nome = item.Nome
            };
        }


        public void AddOrUpdateList(List<FilhosSolteirosRequestViewModel> list, int IdCasal)
        {
            list.ForEach(x =>
            {
                x.CasalId = IdCasal;
                AddOrUpdate(x);
            });
        }
    }
}
