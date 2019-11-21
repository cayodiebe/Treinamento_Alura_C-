using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Funcionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(double Salario, string CPF)
        {
            this.Salario = Salario;
            this.CPF = CPF;
            TotalDeFuncionario++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
        
    }
}
