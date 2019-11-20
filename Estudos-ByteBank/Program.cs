using Estudos_ByteBank.Funcionarios;
using System;

namespace Estudos_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario carlos = new Funcionario();
            carlos.CPF = "3127321331";
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor();
            roberta.CPF = "813232121";
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Funcionario robertaTeste = roberta;
            Console.WriteLine("Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Funcionario: " + robertaTeste.GetBonificacao());

            Console.WriteLine("Total: " + gerenciador.GetTotalBonificacao());
        }
    }
}
