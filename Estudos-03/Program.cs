using System;

namespace Estudos_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863212;
            contaDaGabriela.numero = 863;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863212;
            contaDaGabrielaCosta.numero = 863;

            Console.WriteLine("Igualdade Tipo de Referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;
            
            Console.WriteLine("Igualdade Tipo de Valor: " + (idade == idadeMaisUmaVez));


            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Igualdade Tipo de Teste: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.300);
            Console.WriteLine(contaDaGabrielaCosta.300);

            Console.ReadLine();


        }
    }
}
