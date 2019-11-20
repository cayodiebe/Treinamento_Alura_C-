using Estudos_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            _totalBonificacao +=  diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


    }
}
