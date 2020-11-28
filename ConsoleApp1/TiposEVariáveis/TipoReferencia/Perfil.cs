using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEVariáveis.TipoReferencia
{
    public class Perfil
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public string SalvarPerfil()
        {
            return "Salvando perfil";
        }
    }
}
