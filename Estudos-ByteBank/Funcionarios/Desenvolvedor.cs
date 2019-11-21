using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(double Salario, string cpf) : base(Salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
