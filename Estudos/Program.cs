using System;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.saldo = 100;
            contaDaGabriela.numero = 31731;

            contaDaGabriela.saldo += 200;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agência " + contaDaGabriela.agencia);
            Console.WriteLine("Numero " + contaDaGabriela.numero);
            Console.WriteLine("Saldo " + contaDaGabriela.saldo );

            Console.ReadLine();
        }
    }
}
