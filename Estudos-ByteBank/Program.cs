using Estudos_ByteBank.Funcionarios;
using Estudos_ByteBank.Sistemas;
using System;

namespace Estudos_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(5000, "123456789");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";


            GerenteDeConta camila = new GerenteDeConta(4000, "123456789");
            camila.Nome = "Camila";
            camila.Senha = "ABC";

            Funcionario pedro = new Designer(3000, "123456789");
            pedro.Nome = "Pedro";

            sistemaInterno.Logar(camila, "ABC");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "321");
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
