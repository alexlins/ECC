using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Request
{
    public class CasalVisitadorRequestViewModel
    {
        public int IdCasalVisitador { get; set; }
        public string NomeEle { get; set; }
        public string NomeEla { get; set; }
        public string CelularEle { get; set; }
        public string CelularEla { get; set; }
        public string Email { get; set; }
        public DateTime DtVisita { get; set; }
        public bool Confirmou { get; set; }
        public bool ConducaoPropria { get; set; }
        public string Equipe { get; set; }
        public string RestricaoAlimentar { get; set; }
        public string ApelidoEle { get; set; }
        public string ApelidoEla { get; set; }
        public string Observacoes { get; set; }
        public int IdInscricao { get; set; }
    }
}
