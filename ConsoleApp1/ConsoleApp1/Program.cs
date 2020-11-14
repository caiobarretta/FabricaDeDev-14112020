using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário de uma linha
            /*
             * Comentários
             * de
             * varias
             * linhas
             */
            Console.WriteLine("Hello, World!");
            //ou cancatenando
            Console.WriteLine("Hello, " + "World!");
            //ou passando como parametro
            Console.WriteLine("Hello, {0}", "World!");
            //ou
            Console.WriteLine("{0}, {1}", "Hello", "World!");
            //Interpolação de string
            Console.WriteLine($"{"Hello"},{" World!"}");
        }
    }
}