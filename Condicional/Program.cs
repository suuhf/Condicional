using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando adicionais!");
            Console.WriteLine();

            int idadeSuellen = 11;
            int NumDeAcompanhantes = 1;

            if (idadeSuellen >= 18)


            {

                Console.WriteLine("Legal! Você é maior de 18 anos e pode entrar no cinema!");
                Console.WriteLine("Seja bem-vindx");

            }

            else

            {
                if (NumDeAcompanhantes >= 2)

                {
                    Console.WriteLine("Você não tem mais de 18 anos, mas pode entrar acompanhandx!");

                }
                else
                {

                    Console.WriteLine("Infelizmente você é menor de 18 anos e poderá entrar somente acompanhadx!");
                }
            }
        }
    }
}