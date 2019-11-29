using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos_07
{
    public class OperacaoFinanceiraException : Exception
    {

        public OperacaoFinanceiraException() { }
        public OperacaoFinanceiraException(string mensagem , Exception exceptionIinterna) : base(mensagem, exceptionIinterna) {
        
        }
        public OperacaoFinanceiraException(string mensagem) : base (mensagem) { }
    }
}
