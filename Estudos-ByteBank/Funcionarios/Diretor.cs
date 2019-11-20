﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        
        public double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}
