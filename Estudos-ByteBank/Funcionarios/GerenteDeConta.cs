﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {

        public GerenteDeConta(double Salario, string cpf) : base(Salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
