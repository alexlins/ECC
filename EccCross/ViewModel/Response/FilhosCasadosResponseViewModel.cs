﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Response
{
    public class FilhosCasadosResponseViewModel
    {
        public int FilhoId { get; set; }
        public int CasalId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
