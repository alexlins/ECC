using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel
{
    public class InscricaoResponseViewModel
    {
        public int IdInscricao { get; set; }
        public int IdEncontro { get; set; }
        public int IdCasal { get; set; }
        public bool Participou { get; set; }
    }
}
