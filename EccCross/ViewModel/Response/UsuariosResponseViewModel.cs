using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EccCross.ViewModel.Response
{
    public class UsuariosResponseViewModel
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public bool IsActive { get; set; }
        public short Nivel { get; set; }
    }
}
