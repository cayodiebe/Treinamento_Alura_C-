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
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divisão por 0");

            }
            catch (Exception ex)
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
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da Divisão por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.Write("Exceção com 0");
                throw;
            }
        }


    }
}
