using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public interface Visitor
    {
        public void visitaSoma(Soma soma);
        public void visitaSubtracao(Subtracao subtracao);
        public void visitaNumero(Numero numero);

        public void visitaDivisao(Divisao divisao);

        public void visitaRaizQuadrada(RaizQuadrada raiz);

        public void visitaMultiplicacao(Multiplicacao multiplicacao);
    }
}
