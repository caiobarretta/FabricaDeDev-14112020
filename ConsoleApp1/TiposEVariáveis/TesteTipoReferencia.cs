using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEVariáveis
{
    class TesteTipoReferencia
    {
        public int b { get; set; }
        public void Teste(out int a)
        {
            a = 10;
        }
    }
}
