using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Response
{
    public class EncontroResponseViewModel
    {
        public int EncontroId { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime? DtInicial { get; set; }
        public DateTime? DtFinal { get; set; }
        public bool? EventoConfirmado { get; set; }
        public bool? EventoRealizado { get; set; }
        public int? QtdeCasais { get; set; }
    }
}
