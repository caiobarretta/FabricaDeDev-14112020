using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEVariáveis.TipoReferencia
{
    //Internal é visualizado dentro do mesmo namespace
    //Internal class Usuario 
    //Class Usuario
    //public - Pode Ser visualizado em Dentro e Fora do namespace
    //private - Pode ser visualizado só dentro da classe.
    public class Usuario
    {
        //Os membros de classe, incluindo classes aninhada, podem ser públicos, interno protegido,
        //protegidos, internos, privados ou protegidos privados. Os membros são privados por padão
        private class UsarioDTO
        {
            public int CodigoUsuario { get; set; }
        }

        //Construtores
        public Usuario()
        {

        }
        public Usuario(int CodigoUsuario) //Sobrecarga de construtor
        {
            //Todo
        }

        //Constantes
        public const int CodigoPerfil = 1;

        //Campos/Fields
        private string tipoUsuario;
        public int codigoTipoUsuario;//NÃO RECOMENDADO (É recomendado encapsular em uma propriedade)

        //Finalizadores
        ~Usuario()//Utilizado geralmente no consumo de recursos externos não gerenciados pela CLR
        {

        }

        //Métodos
        //Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o método e 
        //especificando os argumentos de método necessários. No C#, todas as instruções executadas são realizadas no contexto de um método. 
        //O Main método é o ponto de entrada para cada aplicativo C# e é chamado pelo Common Language Runtime (CLR) quando o programa é iniciado.
        //Os métodos são declarados em uma classe, structou interface especificando o nível de acesso, como public ou private , modificadores opcionais, 
        //como abstract ou sealed , o valor de retorno, 
        //o nome do método e qualquer parâmetro de método. Juntas, essas partes são a assinatura do método.
        public void Metodo()
        {
            this.MetodoPrivado();
            //ou
            MetodoPrivado();
        }

        private void MetodoPrivado()
        {

        }

        protected void MetodoProtegido()
        {

        }

    }
}
