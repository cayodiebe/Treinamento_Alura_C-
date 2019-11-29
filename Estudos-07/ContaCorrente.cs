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
            totalDeContasCriadas++;
            TaxaDeOperacao = 30 / totalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor Invalido para o Saque", nameof(valor) );

            if (this._saldo < valor)
                throw new SaldoInsulficienteException(Saldo, valor);

            this._saldo -= valor;
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
                throw new ArgumentException("Valor Invalido para a transferencia", nameof(valor));

            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }

}
