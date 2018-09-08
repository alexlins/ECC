using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccDomain.ViewModel;

namespace EccDomain
{
    public class Encontro
    {
        public bool GravarEncontro(EncontroRequestViewModel viewModel)
        {
            bool resultado = false;
            // Verificar se os dados estão corretos


            if (viewModel.DtFinal < viewModel.DtInicial)
                return false;


            //Fazer a chamada para gravar
            resultado = true;
            // Retornar o resultado verdadeiro ou falso.
            return resultado;
        }
    }
}
