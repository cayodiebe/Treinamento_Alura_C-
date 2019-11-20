using System;

namespace Estudos_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "40521304120";
            //gabriela.profissao = "Desenvolvedora";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();
            conta.titular.cpf = "4051233213";
            conta.titular.profissao = "Desenvolvedora C#";
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
            //conta.titular = gabriela;
            conta.numero = 1234;
            conta.saldo = 500;
            conta.agencia = 13214;


            conta.titular.nome = "Gabriela Costa";

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
