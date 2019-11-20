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
            contaDaGabrielaCosta.agencia = 123456;
            contaDaGabrielaCosta.numero = 863;

            Console.WriteLine("Igualdade Tipo de Referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;
            
            Console.WriteLine("Igualdade Tipo de Valor: " + (idade == idadeMaisUmaVez));


            Console.WriteLine("Igualdade Tipo de Teste: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);

            Console.WriteLine(contaDaGabriela.saldo);
            bool ResultDosaque = contaDaGabriela.Sacar(500);
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(ResultDosaque);

            contaDaGabriela.Depositar(500);
            Console.WriteLine(contaDaGabriela.saldo);

            Console.WriteLine("Saldo Da Gabriela" + contaDaGabriela.saldo);
            Console.WriteLine("Saldo Da Gabriela Costa" + contaDaGabrielaCosta.saldo);

            bool resultTransfer = contaDaGabriela.Transferir(200, contaDaGabrielaCosta);
            Console.WriteLine("Saldo Da Gabriela" + contaDaGabriela.saldo);
            Console.WriteLine("Saldo Da Gabriela Costa" + contaDaGabrielaCosta.saldo);
            Console.WriteLine(resultTransfer);

            



            Console.ReadLine();


        }
    }
}
