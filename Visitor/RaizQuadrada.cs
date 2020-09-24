using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class RaizQuadrada : Expressao
    {
        private Expressao expressao;
        public RaizQuadrada(Expressao expressao)
        {
            this.expressao = expressao;

        }

        public void aceita(Visitor visitor)
        {
            visitor.visitaRaizQuadrada(this);
        }

        public Expressao getExpressao()
        {
            return this.expressao;
        }

        public double avalia()
        {
            return (int)Math.Sqrt(expressao.avalia());
        }
    }
}
