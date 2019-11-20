﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_06
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string Cpf { 
            
            get { return _cpf; } 
            set { //Escrevo minha validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
