using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Response
{
    public class CasaisConvidadoresResponseViewModel
    {
        public int IdCasalConvidador { get; set; }
        public string NomeEle { get; set; }
        public string NomeEla { get; set; }
        public string CelularEle { get; set; }
        public string CelularEla { get; set; }
        public string EmailEle { get; set; }
        public string EmailEla { get; set; }
        public string IgrejaEle { get; set; }
        public string IgrejaEla { get; set; }
        public string Equipe { get; set; }
    }
}
