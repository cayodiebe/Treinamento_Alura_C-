using System;

namespace Estudos_07
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                ContaCorrente cd = new ContaCorrente(4, 123132);
                ContaCorrente cd2 = new ContaCorrente(42, 123132);

                cd.Transferir(10000, cd2);
                cd.Depositar(400);
                Console.WriteLine(cd.Saldo);
                cd.Sacar(5100);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}
