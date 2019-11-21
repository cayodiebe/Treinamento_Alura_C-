using Estudos_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(double salario, string CPF) : base(salario, CPF)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
