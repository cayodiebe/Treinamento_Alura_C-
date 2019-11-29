using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_07
{
    public class SaldoInsulficienteException :  Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsulficienteException(string message) : base(message){}
        public SaldoInsulficienteException(){}

        public SaldoInsulficienteException(double saldo, double valorSaque) : this ("Tentativa de Saque no valor de " + valorSaque + ", inválida.") 
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
