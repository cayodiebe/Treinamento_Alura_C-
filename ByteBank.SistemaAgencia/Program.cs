using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            Console.WriteLine(url);

            ExtratorDeValorArgumentosURL extratorURL = new ExtratorDeValorArgumentosURL();
            int indiceInterrogacao = url.IndexOf('?');
            string argumentos = url.Substring(indiceInterrogacao+1);
            Console.WriteLine(argumentos);

            argumentos.


            Console.ReadLine();

        }
    }
}
