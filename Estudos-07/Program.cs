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

        }
    }
}
