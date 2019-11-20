using System;

namespace Estudos_06
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Cayo";
            cliente.Cpf = "3219813221";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            conta.Saldo = -10;



            Console.WriteLine(conta.Saldo);
            Console.ReadLine() ;
        }
    }
}
