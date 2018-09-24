using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Response
{
    public class InscricaoResponseViewModel
    {
        public int IdInscricao { get; set; }
        public int IdEncontro { get; set; }
        public int IdCasal { get; set; }
        public bool Participou { get; set; }
        public int IdCasalVisitador { get; set; }
        public int IdCasalConvidador { get; set; }

        public CasalResponseViewModel Casal { get; set; }
        public EncontroResponseViewModel Encontro { get; set; }
        public List<CasalVisitadorResponseViewModel> ListaVisitadores {get;set;}
        public CasaisConvidadoresResponseViewModel Convidador { get; set; }
    }
}
