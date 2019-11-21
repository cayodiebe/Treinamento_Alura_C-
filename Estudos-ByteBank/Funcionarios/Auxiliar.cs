using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(double Salario, string cpf) : base(Salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
