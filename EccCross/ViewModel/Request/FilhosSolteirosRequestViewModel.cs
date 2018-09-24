using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Request
{
    public class FilhosSolteirosRequestViewModel
    {
        public int FilhoId { get; set; }
        public int CasalId { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
    }
}
