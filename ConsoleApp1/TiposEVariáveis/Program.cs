using System;

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
            //Tipos de valor:
            //  Tipos Simples:
            //      Signed: sbyte, short, int, long
            sbyte valorMaximoDeUmSByte = sbyte.MaxValue;
            sbyte valorMinimoDeUmSByte = sbyte.MinValue;

            Console.WriteLine("Valor máximo de um sbyte: {0}", valorMaximoDeUmSByte);
            Console.WriteLine("Valor mínimo de um sbyte: {0}", valorMinimoDeUmSByte);

            short valorMaximoDeUmShort = short.MaxValue;
            short valorMínimoDeUmShort = short.MinValue;
            Console.WriteLine("Valor máximo de um short: {0}", valorMaximoDeUmShort);
            Console.WriteLine("Valor mínimo de um short: " + valorMínimoDeUmShort);

            int valorMaximoDeUmInteiro = int.MaxValue;
            int valorMinimoDeUmInteiro = int.MinValue;
            Console.WriteLine($"Valor Máximo de um Inteiro: {valorMaximoDeUmInteiro}");
            string valorMinimoDeUmInteiroTexto = "Valor Mínimo de " +
                "um Intero:" +
                $"{valorMinimoDeUmInteiro}";
            Console.WriteLine(valorMinimoDeUmInteiroTexto);

            string malandragemDoChute = string.Empty;
            malandragemDoChute += "";

            long valorMaximoDeUmLong = long.MaxValue;
            long valorMinimoDeUmLong = long.MinValue;

            string sugestaoDePularLinhaDoChute = "Valor Máximo de" + "\n" +
                "um long" + "\n" +
                $"{valorMaximoDeUmLong}";
            Console.WriteLine(sugestaoDePularLinhaDoChute);

            string sugestaoDePularLinhaMaisElegante = "Valor Mínimo de" + Environment.NewLine
                + "um long" + Environment.NewLine +
                $"{valorMinimoDeUmLong}";
            Console.WriteLine(sugestaoDePularLinhaMaisElegante);

            Int64 valorMaximoInt64 = Int64.MaxValue;
            Console.WriteLine("Valor Máximo de um Int64: {0}", valorMaximoInt64);

            //      Unsigned integral: byte, ushort, uint, ulong
            var valorMaximoDeUmByte = byte.MaxValue;
            var valorMinimoDeUmByte = byte.MinValue;
            Console.WriteLine("Valor máximo de um Byte: {0}", valorMaximoDeUmByte);
            Console.WriteLine("Valor mínimo de um Byte: {0}", valorMinimoDeUmByte);


            var valorMaximoDeUmUShort = ushort.MaxValue;
            var valorMinimoDeUmUShort = ushort.MinValue;
            Console.WriteLine("Valor máximo de um ushort: {0}", valorMaximoDeUmUShort);
            Console.WriteLine("Valor Mínimo de um ushort: {0}", valorMinimoDeUmUShort);

            var valorMaximoDeUmUInt = uint.MaxValue;
            var valorMinimoDeUmUInt = uint.MinValue;
            Console.WriteLine("Valor máximo de um uint: {0}", valorMaximoDeUmUInt);
            Console.WriteLine("Valor Mínimo de um uint: {0}", valorMinimoDeUmUInt);

            var valorMaximoDeUmULong = ulong.MaxValue;
            var valorMinimoDeUmULong = ulong.MaxValue;
            Console.WriteLine("Valor máximo de um ulong: {0}", valorMaximoDeUmULong);
            Console.WriteLine("Valor Mínimo de um ulong: {0}", valorMinimoDeUmULong);

            //Inteiros Literais
            var inteiroLiteral = 1;
            var hexaDecimaLiteral = 0x9809B84A1F8478F;//0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F
            var binarioLiteral = 0b_010101011111000111011;//0,1
            Console.WriteLine("Inteiro literal: {0}", inteiroLiteral);
            Console.WriteLine("hexadecimal literal: {0}", hexaDecimaLiteral);
            Console.WriteLine("binario literal: {0}", binarioLiteral);

            //      Unicode characters: char, que representa uma unidade de código UTF-16
            char caracterRepresentandoALetraAMinuscula = 'a';
            Console.WriteLine("a: {0}", caracterRepresentandoALetraAMinuscula);

            //      IEEE binary floating-point: float, double
            float valorMaximoFloat = float.MaxValue;
            float valorMinimoFloat = float.MinValue;
            Console.WriteLine("Valor Máximo de um float: {0}", valorMaximoFloat);
            Console.WriteLine("Valor Minimo de um float: {0}", valorMinimoFloat);

            double valorMaximoDouble = double.MaxValue;
            double valorMinimoDouble = double.MinValue;
            Console.WriteLine("Valor Máximo de um double: {0}", valorMaximoDouble);
            Console.WriteLine("Valor Minimo de um double: {0}", valorMinimoDouble);

            var teste = new TesteTipoReferencia();
            teste.b = 1;
            teste.Teste(out inteiroLiteral);
            AlteraTeste(teste);
            Console.WriteLine("Inteiro literal: {0}", inteiroLiteral);
            Console.WriteLine("teste.b: {0}", teste.b);

            var convertidoComSucesso = int.TryParse("Teste", out int resultadoDaConversaoDeTeste);
            Console.WriteLine("O Valor foi convertido com sucesso?: {0}", convertidoComSucesso);
            Console.WriteLine("O Valor: {0}", resultadoDaConversaoDeTeste);

            var convertidoDeTesteSemTryparse = int.Parse("123");
            Console.WriteLine("Valor convertido de Teste Sem Try Parse: {0}", convertidoDeTesteSemTryparse);

            var convertidoComSucessoValorDeVinte = int.TryParse("20", out int resultadoDaConversaoDeVinte);
            Console.WriteLine("O Valor foi convertido com sucesso?: {0}", convertidoComSucessoValorDeVinte);
            Console.WriteLine("O Valor: {0}", resultadoDaConversaoDeVinte);

            //Console.Write("Entre com um valor numerico: ");
            ////var valorDigitadoEhInteiro = int.TryParse(Console.ReadLine(), out int valorDigitado);
            ////Console.WriteLine("O Valor Digitado está certo?:{0} foi: {1}", valorDigitadoEhInteiro, valorDigitado);

            //var valorDigitadoTexto = string.Empty;
            //try
            //{
            //    //Console.Write("Entre com um valor numerico: ");
            //    //valorDigitadoTexto = Console.ReadLine();
            //    //valorDigitado = Convert.ToInt32(valorDigitadoTexto);
            //    //Console.WriteLine("O Valor Digitado foi: {1}", valorDigitado);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Formato Errado: {valorDigitadoTexto}");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine($"Valor muito Grande: {valorDigitadoTexto}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Excessão desconhecida!");
            //}

            //      high-precision decimal floating-point: decimal
            decimal valorMaximoDecimal = decimal.MaxValue;
            decimal valorMinimoDecimal = decimal.MinValue;
            Console.WriteLine($"Valor máximo de um decimal: {valorMaximoDecimal}");
            Console.WriteLine($"Valor minimo de um decimal: {valorMinimoDecimal}");

            bool representaUmVAlorBolleanoVerdadeiro = true;
            bool representaUmVAlorBolleanoFalso = false;
            Console.WriteLine($"Valor máximo de um booliano: {representaUmVAlorBolleanoVerdadeiro}");
            Console.WriteLine($"Valor minimo de um booliano: {representaUmVAlorBolleanoFalso}");

            //  Tipo de enumeração:
            //      Tipos definidos pelo usuário do formulário enum E {...}
            //      Um tipo enum é um tipo distindo de constantes nomeadas.
            //      Cada Tipo enum tem um tipo subjacenter, que deve ser um dos oito tipo integrais.
            //      O conjunto de valore de um tipo enum é o mesmo que o conjunto de valores do tipo subjacente.
            diasDaSemana diaDaSemana = diasDaSemana.domingo;
            Console.WriteLine("Dia da semana: {0}, valor: {1}", diaDaSemana, (int)diaDaSemana);
            diaDaSemana = diasDaSemana.segunda;
            Console.WriteLine("Dia da semana: {0}, valor: {1}", diaDaSemana, (int)diaDaSemana);


        }

        static void AlteraTeste(TesteTipoReferencia teste)
        {
            teste.b = 10;
        }
    }
}
