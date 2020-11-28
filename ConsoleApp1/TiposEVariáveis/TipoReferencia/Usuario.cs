using System;
using System.Collections.Generic;
using System.Linq;
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

        void Teste()
        {

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

        public virtual void SalvarUsuario(string nome, int codigoUsuario = 0)
        {
            Console.WriteLine("Teste Salvar Usuário classe pai!");
        }


        //Propriedades
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public void SetMyProperty(int valueMyVar) => myVar = valueMyVar;

        public int GetMyProperty() => myVar;

        public String PropriedadeString { get; set; }

        private string nome;
        public string Nome
        {
            get
            {
                if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                    return "Nome Vazio";
                else
                    return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Valor não pode ser nulo");
                else
                    nome = value;
            }
        }

        //Indexadores
        //Os indexadores permitem que instâncias de uma classe ou struct sejam indexados como matrizes.
        //O valor indexado pode ser definido ou recuperado sem especificar explicitamente um membro de instância ou tipo.
        //Os indexadores parecem com propriedades, a diferença é que seus acessadores usam parâmetros.

        //Declara um array para armazer os dados do elemento
        //private int[] ArrayDeInteiros = new int[100];
        private Perfil[] perfils = new Perfil[100];

        //Define o indexador para permitir a utilização de [] na notação
        public Perfil this[int index]
        {
            get { return perfils[index]; }
            set { perfils[index] = value; }
        }
        //Exemplo em um método
        public void AdicionarPerfil(int index, Perfil perfil)
        {
            this[index] = perfil;
        }

        //Operadores
        //O C# fornece vários operadores. Muitos deles têm suporte dos tipos internos e permitem que você execute operações básicas com valores desses tipos. 
        //Esses operadores incluem os seguintes grupos:
        //Operadores aritméticos que executam operações aritméticas com operandos numéricos
        //Operadores de comparação que comparam operandos numéricos
        //Operadores lógicos boolianos que executam operações lógicas com bool operandos
        //Operadores de tecla e bit de alternância que executam operações de bit ou de Shift com operandos dos tipos integrais
        //Operadores de igualdade que verificam se os operandos são iguais ou não

        //exemplos de expressões estão no lado direito das atribuições:

        public void ExemploDeExpressoesEAtribuicoes()
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            c = a >= 100 ? b : c / 10;
            a = (int)Math.Sqrt(b * b + c * c);

            string s = "String literal";
            char l = s[s.Length - 1];

            //int[] arrayInteiros = new int[3];
            //arrayInteiros[0] = 1;
            //....
            //var numbers = new List<int>(arrayInteiros);
            var numbers = new List<int>(new[] { 1, 2, 3 });
            numbers.FindLast(n => n > 1);

            var perfils = new List<Perfil>();
            perfils.Add(new Perfil()
            {
                Codigo = 1,
                Nome = "Teste"
            });
            
            perfils.Add(new Perfil()
            {
                Codigo = 2,
                Nome = "Alface"
            });
            perfils.FindLast(p => p.Nome != "teste");

            //Expressões de cadeia de caracteres interpoladas que
            //fornecem uma sintaxe conveniente para criar cadeias formatadas:
            var r = 2.3;
            var message = $"A área de um círculo com raio {r} é {Math.PI * r * r:F3}";
            Console.WriteLine(message);


            //Expressões lambda que permitem criar funções anônimas:
            int[] numbers2 = { 2, 3, 4, 5 };
            var maximumSquare = numbers2.Max(x => x * x);
            Console.WriteLine(maximumSquare);



        }

    }
}
