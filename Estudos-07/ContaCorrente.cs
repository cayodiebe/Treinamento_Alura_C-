using System;

namespace Estudos_07
{
    public class ContaCorrente
    {
        public static double TaxaDeOperacao { get; private set; }
        private double _saldo = 100;
        private int _agencia;
        //Compartilham essa informaçao;
        public static int totalDeContasCriadas { get; private set; }

        public Cliente Titular{get;set;}
        public int Agencia { get; }

        public int Numero { get; }

        public double Saldo
        {
            get { return _saldo; }
            private set {
                if (value < 0)
                    return;

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero) {
            if (agencia <= 0)
            {
                ArgumentException argumentException = new ArgumentException("Agencia deve ser maior que 0", nameof(agencia));
                throw argumentException;
            }
            if (numero <= 0)
            {
                ArgumentException argumentException = new ArgumentException("numero deve ser maior que 0", nameof(numero));
                throw argumentException;
            }
            Agencia = agencia;
            Numero = numero;
            TaxaDeOperacao = 30 / totalDeContasCriadas;
            totalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
                return false;

            this._saldo -= valor;
            return true;
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
                return false;

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}
