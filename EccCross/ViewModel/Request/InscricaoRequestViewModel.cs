using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Request
{
    public class InscricaoRequestViewModel
    {
        public int IdInscricao { get; set; }
        public int IdEncontro { get; set; }
        public int IdCasal { get; set; }
        public bool Participou { get; set; }
        public int IdCasalVisitador { get; set; }
        public int IdCasalConvidador { get; set; }
        public CasaisConvidadoresRequestViewModel CasalConvidador { get; set; }
        public CasalRequestViewModel Casal { get; set; }
        public CasalVisitadorRequestViewModel CasalVisitador { get; set; }
        public CuidadoresRequestViewModel Cuidadores { get; set; }
        public List<FilhosCasadosRequestViewModel> FilhosCasados { get; set; }
        public List<FilhosSolteirosRequestViewModel> FilhosSolteiros { get; set; }
    }
}
