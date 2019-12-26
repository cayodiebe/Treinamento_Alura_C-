using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorDeValorArgumentosURL
    {
        public string URL { get;  }
        private readonly string _argumetos;
        public ExtratorDeValorArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
                throw new ArgumentNullException("Argumento URl não pode ser Vazio", nameof(url));

            int indiceInderrocacao = url.IndexOf('?');
            _argumetos = url.Substring(indiceInderrocacao + 1);
            URL = url;
        }

        public string GetValor(string NomeParametro)
        {
            int indiceParametro = _argumetos.IndexOf();
            return NomeParametro;
        }

    }
}
