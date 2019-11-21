using Estudos_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_ByteBank.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(Autenticavel funcionarios, string senha)
        {
            bool usuarioAutenticado = funcionarios.Autenticar(senha);
            
            if (!usuarioAutenticado){
                Console.WriteLine("Senha Incorreta");
                return false;

            }
            Console.WriteLine("Bem Vindo ao Sistema");
            return true;
        }
    }
}
