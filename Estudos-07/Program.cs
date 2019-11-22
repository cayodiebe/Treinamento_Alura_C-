using System;

namespace Estudos_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(865, 132138213);
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(123, 13213821);
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);

            Console.WriteLine(ContaCorrente.TaxaDeOperacao);

            try
            {
                Metodo();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Aconteceu um erro");
            }
        }

        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da Divisão por " + divisor + " é " + resultado);
            } catch (DivideByZeroException erro)
            {
                Console.WriteLine("Não é possível fazer uma divisão por 0");
                Console.WriteLine(erro.Message);

            }
        }

        private static int Dividir(int numero, int divisor)
        {
           return numero / divisor;
        }


    }
}
