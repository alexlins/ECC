using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel;

namespace EccDomain
{
    public class Encontro
    {
        private EccInfra.Encontro _infra;

        public Encontro()
        {
            _infra = new EccInfra.Encontro();
        }

        public bool GravarEncontro(EncontroRequestViewModel viewModel)
        {
            // Verificar se os dados estão corretos
            if (String.IsNullOrEmpty(viewModel.Nome))
                return false;

            if (String.IsNullOrEmpty(viewModel.Local))
                return false;

            if (viewModel.DtFinal < viewModel.DtInicial)
                return false;


            //Fazer a chamada para gravar
            var retorno = _infra.AddOrUpdate(viewModel);

            if (retorno == null || retorno.EncontroId == 0)
                return false;
            
                return true;
        }

        public List<EncontroResponseViewModel> GetEncontroByFilter(EncontroRequestViewModel filtro)
        {
            List<EncontroResponseViewModel> resultado = _infra.GetAll();

            if (String.IsNullOrEmpty(filtro.Local) &&
                String.IsNullOrEmpty(filtro.Nome) &&
                filtro.DtInicial == null && filtro.DtFinal == null)
                return resultado;
 
            if(!String.IsNullOrEmpty(filtro.Local))
                resultado = resultado.Where(x=>x.Local == filtro.Local.Trim()).ToList();

            if (!String.IsNullOrEmpty(filtro.Nome))
                resultado = resultado.Where(x => x.Nome == filtro.Nome.Trim()).ToList();

            if(filtro.DtInicial != null)
                resultado = resultado.Where(x => x.DtInicial >= filtro.DtInicial).ToList();

            if (filtro.DtFinal != null)
                resultado = resultado.Where(x => x.DtFinal <= filtro.DtFinal).ToList();

            return resultado;
        }

        public EncontroResponseViewModel GetById(int id)
        {
            return _infra.GetById(id);
        }

        public List<InscricaoResponseViewModel> GetInscritos(int IdEncontro)
        {
            throw new NotImplementedException();
        }
    }
}
