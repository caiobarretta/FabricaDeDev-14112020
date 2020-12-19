using System;
using TiposEVariáveis.TipoReferencia;

namespace TiposEVariáveis
{

    enum diasDaSemana
    {
        domingo = 1000,
        segunda = 100,
        terça,
        quarta,
        quinta,
        sexta,
        sábado
    }

    enum EstaçõesDoAno
    {
        Primavera,
        Verão,
        Inferno,
        Outono
    }

    enum Tênis
    {
        Adidas,
        Fila,
        Nike,
        AllStar
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Aula 14/11/2020
            ////Tipos de valor:
            ////  Tipos Simples:
            ////      Signed: sbyte, short, int, long
            //sbyte valorMaximoDeUmSByte = sbyte.MaxValue;
            //sbyte valorMinimoDeUmSByte = sbyte.MinValue;

            //Console.WriteLine("Valor máximo de um sbyte: {0}", valorMaximoDeUmSByte);
            //Console.WriteLine("Valor mínimo de um sbyte: {0}", valorMinimoDeUmSByte);

            //short valorMaximoDeUmShort = short.MaxValue;
            //short valorMínimoDeUmShort = short.MinValue;
            //Console.WriteLine("Valor máximo de um short: {0}", valorMaximoDeUmShort);
            //Console.WriteLine("Valor mínimo de um short: " + valorMínimoDeUmShort);

            //int valorMaximoDeUmInteiro = int.MaxValue;
            //int valorMinimoDeUmInteiro = int.MinValue;
            //Console.WriteLine($"Valor Máximo de um Inteiro: {valorMaximoDeUmInteiro}");
            //string valorMinimoDeUmInteiroTexto = "Valor Mínimo de " +
            //    "um Intero:" +
            //    $"{valorMinimoDeUmInteiro}";
            //Console.WriteLine(valorMinimoDeUmInteiroTexto);

            //string malandragemDoChute = string.Empty;
            //malandragemDoChute += "";

            //long valorMaximoDeUmLong = long.MaxValue;
            //long valorMinimoDeUmLong = long.MinValue;

            //string sugestaoDePularLinhaDoChute = "Valor Máximo de" + "\n" +
            //    "um long" + "\n" +
            //    $"{valorMaximoDeUmLong}";
            //Console.WriteLine(sugestaoDePularLinhaDoChute);

            //string sugestaoDePularLinhaMaisElegante = "Valor Mínimo de" + Environment.NewLine
            //    + "um long" + Environment.NewLine +
            //    $"{valorMinimoDeUmLong}";
            //Console.WriteLine(sugestaoDePularLinhaMaisElegante);

            //Int64 valorMaximoInt64 = Int64.MaxValue;
            //Console.WriteLine("Valor Máximo de um Int64: {0}", valorMaximoInt64);

            ////      Unsigned integral: byte, ushort, uint, ulong
            //var valorMaximoDeUmByte = byte.MaxValue;
            //var valorMinimoDeUmByte = byte.MinValue;
            //Console.WriteLine("Valor máximo de um Byte: {0}", valorMaximoDeUmByte);
            //Console.WriteLine("Valor mínimo de um Byte: {0}", valorMinimoDeUmByte);


            //var valorMaximoDeUmUShort = ushort.MaxValue;
            //var valorMinimoDeUmUShort = ushort.MinValue;
            //Console.WriteLine("Valor máximo de um ushort: {0}", valorMaximoDeUmUShort);
            //Console.WriteLine("Valor Mínimo de um ushort: {0}", valorMinimoDeUmUShort);

            //var valorMaximoDeUmUInt = uint.MaxValue;
            //var valorMinimoDeUmUInt = uint.MinValue;
            //Console.WriteLine("Valor máximo de um uint: {0}", valorMaximoDeUmUInt);
            //Console.WriteLine("Valor Mínimo de um uint: {0}", valorMinimoDeUmUInt);

            //var valorMaximoDeUmULong = ulong.MaxValue;
            //var valorMinimoDeUmULong = ulong.MaxValue;
            //Console.WriteLine("Valor máximo de um ulong: {0}", valorMaximoDeUmULong);
            //Console.WriteLine("Valor Mínimo de um ulong: {0}", valorMinimoDeUmULong);

            ////Inteiros Literais
            //var inteiroLiteral = 1;
            //var hexaDecimaLiteral = 0x9809B84A1F8478F;//0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F
            //var binarioLiteral = 0b_010101011111000111011;//0,1
            //Console.WriteLine("Inteiro literal: {0}", inteiroLiteral);
            //Console.WriteLine("hexadecimal literal: {0}", hexaDecimaLiteral);
            //Console.WriteLine("binario literal: {0}", binarioLiteral);

            ////      Unicode characters: char, que representa uma unidade de código UTF-16
            //char caracterRepresentandoALetraAMinuscula = 'a';
            //Console.WriteLine("a: {0}", caracterRepresentandoALetraAMinuscula);

            ////      IEEE binary floating-point: float, double
            //float valorMaximoFloat = float.MaxValue;
            //float valorMinimoFloat = float.MinValue;
            //Console.WriteLine("Valor Máximo de um float: {0}", valorMaximoFloat);
            //Console.WriteLine("Valor Minimo de um float: {0}", valorMinimoFloat);

            //double valorMaximoDouble = double.MaxValue;
            //double valorMinimoDouble = double.MinValue;
            //Console.WriteLine("Valor Máximo de um double: {0}", valorMaximoDouble);
            //Console.WriteLine("Valor Minimo de um double: {0}", valorMinimoDouble);

            //var teste = new TesteTipoReferencia();
            //teste.b = 1;
            //teste.Teste(out inteiroLiteral);
            //AlteraTeste(teste);
            //Console.WriteLine("Inteiro literal: {0}", inteiroLiteral);
            //Console.WriteLine("teste.b: {0}", teste.b);

            //var convertidoComSucesso = int.TryParse("Teste", out int resultadoDaConversaoDeTeste);
            //Console.WriteLine("O Valor foi convertido com sucesso?: {0}", convertidoComSucesso);
            //Console.WriteLine("O Valor: {0}", resultadoDaConversaoDeTeste);

            //var convertidoDeTesteSemTryparse = int.Parse("123");
            //Console.WriteLine("Valor convertido de Teste Sem Try Parse: {0}", convertidoDeTesteSemTryparse);

            //var convertidoComSucessoValorDeVinte = int.TryParse("20", out int resultadoDaConversaoDeVinte);
            //Console.WriteLine("O Valor foi convertido com sucesso?: {0}", convertidoComSucessoValorDeVinte);
            //Console.WriteLine("O Valor: {0}", resultadoDaConversaoDeVinte);

            //Console.Write("Entre com um valor numerico: ");
            //var valorDigitadoTexto = Console.ReadLine();
            //var valorDigitadoEhInteiro = int.TryParse(valorDigitadoTexto, out int valorDigitado);
            //if (valorDigitadoEhInteiro)
            //{
            //    Console.WriteLine("Valor válido:{0}", valorDigitadoTexto);
            //}
            //else
            //{
            //    Console.WriteLine("Valor inválido:{0}", valorDigitadoTexto);
            //}
            //Console.WriteLine("O Valor Digitado está certo?:{0} foi: {1}", valorDigitadoEhInteiro, valorDigitado);

            Console.Write("Entre com um valor numerico: ");
            var valorDigitadoTexto = Console.ReadLine();
            var valorDigitadoEhInteiro = int.TryParse(valorDigitadoTexto, out int valorDigitado);
            if (valorDigitadoEhInteiro)
            {
                Console.WriteLine("Valor válido:{0}", valorDigitadoTexto);
                // Operador: || (OU)
                // Operador: && (E)
                // Operador: ! (Não)
                if (valorDigitado <= sbyte.MaxValue && valorDigitado >= sbyte.MinValue)
                {
                    Console.WriteLine("Melhor tipo para ser armazenado é o sbyte!");
                }
                else
                {
                    Console.WriteLine("Implemente Você!");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido:{0}", valorDigitadoTexto);
            }

            

            ////var valorDigitadoTexto = string.Empty;
            ////try
            ////{
            ////    //Console.Write("Entre com um valor numerico: ");
            ////    //valorDigitadoTexto = Console.ReadLine();
            ////    //valorDigitado = Convert.ToInt32(valorDigitadoTexto);
            ////    //Console.WriteLine("O Valor Digitado foi: {1}", valorDigitado);
            ////}
            ////catch (FormatException ex)
            ////{
            ////    Console.WriteLine($"Formato Errado: {valorDigitadoTexto}");
            ////}
            ////catch (OverflowException ex)
            ////{
            ////    Console.WriteLine($"Valor muito Grande: {valorDigitadoTexto}");
            ////}
            ////catch (Exception ex)
            ////{
            ////    Console.WriteLine("Excessão desconhecida!");
            ////}

            ////      high-precision decimal floating-point: decimal
            //decimal valorMaximoDecimal = decimal.MaxValue;
            //decimal valorMinimoDecimal = decimal.MinValue;
            //Console.WriteLine($"Valor máximo de um decimal: {valorMaximoDecimal}");
            //Console.WriteLine($"Valor minimo de um decimal: {valorMinimoDecimal}");

            //bool representaUmVAlorBolleanoVerdadeiro = true;
            //bool representaUmVAlorBolleanoFalso = false;
            //Console.WriteLine($"Valor máximo de um booliano: {representaUmVAlorBolleanoVerdadeiro}");
            //Console.WriteLine($"Valor minimo de um booliano: {representaUmVAlorBolleanoFalso}");

            ////  Tipo de enumeração:
            ////      Tipos definidos pelo usuário do formulário enum E {...}
            ////      Um tipo enum é um tipo distindo de constantes nomeadas.
            ////      Cada Tipo enum tem um tipo subjacenter, que deve ser um dos oito tipo integrais.
            ////      O conjunto de valore de um tipo enum é o mesmo que o conjunto de valores do tipo subjacente.
            //diasDaSemana diaDaSemana = diasDaSemana.domingo;
            //Console.WriteLine("Dia da semana: {0}, valor: {1}", diaDaSemana, (int)diaDaSemana);
            //diaDaSemana = diasDaSemana.segunda;
            //Console.WriteLine("Dia da semana: {0}, valor: {1}", diaDaSemana, (int)diaDaSemana);

            //21/11/2020
            //  Tipos struct:
            //      Tipos definidos pelo usuário do formulário struct S {...}
            //Aluno aluno;
            //aluno.CodigoAluno = 1;
            //aluno.Nome = "Nome do aluno";
            //aluno.Idade = 18;
            //aluno.Nota = 10.00F;
            //Console.WriteLine("Nome do aluno: {0}", aluno.Nome);
            //Console.WriteLine("Idade do aluno: {0}", aluno.Idade);
            //Console.WriteLine("Nota do aluno: {0}", aluno.Nota);

            //Professor professor;
            //professor.Nome = "Nome do professor";
            //professor.Idade = 27;
            //Console.WriteLine("Nome do professor: {0}", professor.Nome);
            //Console.WriteLine("Idade do professor: {0}", professor.Idade);

            //Aluno aluno2;
            //aluno2.CodigoAluno = 1;
            //aluno2.Nome = "Aluno 2";
            //aluno2.Idade = 19;
            //aluno2.Nota = 9.0F;

            //try
            //{
            //    //"Teste".Equals(null);
            //    var ehAluno = aluno.CompareTo(aluno2) == 1;
            //    if (ehAluno)
            //    {
            //        Console.WriteLine("Bem vindo Aluno: {0}", aluno.Nome);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Acesso Proibido!");
            //    }
            //}
            //catch (NotSupportedException ex)
            //{
            //    Console.WriteLine("Erro de comparação: {0}", ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro: {0}", ex.Message);
            //}

            ////Console.ReadKey();

            ////  Tipos de valor Anuláveis:
            ////      Extensões de todos os outros tipos de valor com um valor null
            //sbyte? valorMaximoDeUmSByte = sbyte.MaxValue;
            //sbyte? valorMinimoDeUmSByte = sbyte.MinValue;

            //Console.WriteLine("Valor máximo de um sbyte: {0}", valorMaximoDeUmSByte);
            //Console.WriteLine("Valor mínimo de um sbyte: {0}", valorMinimoDeUmSByte);

            //short? valorMaximoDeUmShort = short.MaxValue;
            //short? valorMínimoDeUmShort = short.MinValue;
            //Console.WriteLine("Valor máximo de um short: {0}", valorMaximoDeUmShort);
            //Console.WriteLine("Valor mínimo de um short: " + valorMínimoDeUmShort);

            //int? valorMaximoDeUmInteiro = int.MaxValue;
            //int? valorMinimoDeUmInteiro = int.MinValue;
            //Console.WriteLine($"Valor Máximo de um Inteiro: {valorMaximoDeUmInteiro}");
            //string valorMinimoDeUmInteiroTexto = "Valor Mínimo de " +
            //    "um Intero:" +
            //    $"{valorMinimoDeUmInteiro}";
            //Console.WriteLine(valorMinimoDeUmInteiroTexto);

            //string malandragemDoChute = string.Empty;
            //malandragemDoChute += "";

            //long? valorMaximoDeUmLong = long.MaxValue;
            //long? valorMinimoDeUmLong = long.MinValue;

            //string sugestaoDePularLinhaDoChute = "Valor Máximo de" + "\n" +
            //    "um long" + "\n" +
            //    $"{valorMaximoDeUmLong}";
            //Console.WriteLine(sugestaoDePularLinhaDoChute);

            //string sugestaoDePularLinhaMaisElegante = "Valor Mínimo de" + Environment.NewLine
            //    + "um long" + Environment.NewLine +
            //    $"{valorMinimoDeUmLong}";
            //Console.WriteLine(sugestaoDePularLinhaMaisElegante);

            //int? quantidadeDeProdutos = 0;
            ////0:0/1:2^0/2:2^1
            //if (quantidadeDeProdutos == null)//(!quantidadeDeProdutos.HasValue)
            //{
            //    //To-do
            //}

            //var EhMaladragemMesmo = string.IsNullOrEmpty(malandragemDoChute);

            //int? CodigoPerfilUsuario = null;

            //int? ReviewNullabel = 0;
            //int valor = ReviewNullabel.HasValue ? ReviewNullabel.Value : 0;
            //ReviewNullabel.GetValueOrDefault();

            //Console.WriteLine($"Valor do Código Perfil Usuario: {CodigoPerfilUsuario}");
            //Console.WriteLine($"tem Valor no Código Perfil Usuario?: {CodigoPerfilUsuario.HasValue}");
            ////Lança um erro, pois a referencia do objeto é nulas
            ////Console.WriteLine($"Valor do Código Perfil Usuario: {CodigoPerfilUsuario.Value}");

            //var valorCodigoPerfilUsuario = CodigoPerfilUsuario.GetValueOrDefault();
            //Console.WriteLine($"Valor do CódigoPerfil Usuario: {valorCodigoPerfilUsuario}");

            ////  Tipos de valor tupla:
            ////      Tipos definidos pelo usuário do formulário (T1, t2, ...)
            //(double, double) valorDaTuplaDouble = (-1.0, 1.0);
            //Console.WriteLine("Primeiro valor da tupla: {0}", valorDaTuplaDouble.Item1);
            //Console.WriteLine(" segundo valodr da tupla:{0}", valorDaTuplaDouble.Item2);

            //var coordenadaCartesiana = (x: 1.0, y: 2.0);
            //Console.WriteLine("Coordenada Cartesiana x: {0}", coordenadaCartesiana.x);
            //Console.WriteLine("Coordenada Cartesiana y: {0}", coordenadaCartesiana.y);
            ////ou
            //var (x1, y1) = (0.0, 0.0);
            //Console.WriteLine("Coordenada Cartesiana: x:{0} e y:{1}", x1, y1);

            //var retornoExemploTupla = aluno.ExemploTupla();
            //Console.WriteLine("Retorno do ExemploTupla:");
            //Console.WriteLine("Nome: {0}", retornoExemploTupla.Item1);
            //Console.WriteLine("Idade: {0}", retornoExemploTupla.Item2);
            //Console.WriteLine("Nota: {0}", retornoExemploTupla.Item3);

            //Tipo Referência
            //Usuario usuario = new Usuario();
            //var usuario2 = new Usuario();

            //UsuarioFilho filho = new UsuarioFilho();
            //filho.SalvarUsuario("Teste", 1);

            //Usuario usuario = new Usuario();
            //Console.WriteLine($"Nome do usuário:{usuario.Nome}");
            //var nome = Console.ReadLine();
            //try
            //{
            //    usuario.Nome = nome;
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine($"Nome do usuário:{usuario.Nome}");

            //var usuarios = new Usuario();
            //usuarios[0] = 1;
            //Console.WriteLine("usuarios[0]:" + usuarios[0]);

            //var usuarios = new Usuario();
            //usuarios[0] = new Perfil()
            //{
            //    Codigo = 1,
            //    Nome = "Administrador"
            //};

            //Console.WriteLine("Nome do primeiro Perfil: {0}", usuarios[0].SalvarPerfil());

            //var usuarios = new Usuario();
            //usuarios.AdicionarPerfil(0, new Perfil()
            //{
            //    Codigo = 1,
            //    Nome = "Administrador"
            //});

            //Console.WriteLine("Nome do primeiro Perfil: {0}", usuarios[0].Nome);

        }

        static void AlteraTeste(TesteTipoReferencia teste)
        {
            teste.b = 10;
        }
    }
}
