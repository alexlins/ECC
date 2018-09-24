using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Response
{
    public class CuidadoresResponseViewModel
    {
        public int CuidadorId { get; set; }
        public int CasalId { get; set; }
        public string Nome { get; set; }
        public string Parentesco { get; set; }
        public string Fone { get; set; }
        public string Endereço { get; set; }
        public string PontoReferencia { get; set; }
    }
}
