using Estudos_ByteBank.Funcionarios;
using System;

namespace Estudos_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer(3000, "123456789");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor(5000, "123456789");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar(2000, "123456789");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta(4000, "123456789");
            camila.Nome = "Camila";

            Funcionario carlos = new Desenvolvedor(3000, "123456789");
            carlos.Nome = "Carlos";

            gerenciadorBonificacao.Registrar(carlos);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificação: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
