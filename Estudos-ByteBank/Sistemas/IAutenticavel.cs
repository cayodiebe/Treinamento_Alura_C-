using Estudos_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Sistemas
{
    public interface IAutenticavel 
    {
        public bool Autenticar(string senha);
    }
}
