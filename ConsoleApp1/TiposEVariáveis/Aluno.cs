using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEVariáveis
{
    struct Aluno : IComparable
    {
        public int CodigoAluno;
        public string Nome;
        public int Idade;
        public float Nota;

        public int CompareTo(object obj)
        {
            if (obj is Professor)
            {
                return 0;
            }
            if (obj is Aluno)
            {
                var aluno = (Aluno)obj;
                var ehMesmoAluno = aluno.CodigoAluno == this.CodigoAluno;
                if (ehMesmoAluno)
                {
                    return 1;
                }
                return 0;
            }
            throw new NotSupportedException("Só é possível comparar Aluno com Aluno ou professor!");
        }

        public (string, int, float) ExemploTupla()
        {
            return (this.Nome, this.Idade, this.Nota);
        }
    }
}
