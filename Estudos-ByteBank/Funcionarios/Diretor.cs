using Estudos_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        
        public Diretor(double Salario, string cpf) : base(Salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return true;
        }
      
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
