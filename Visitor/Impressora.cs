using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Impressora : Visitor
    {
        public void visitaNumero(Numero numero)
        {
            Console.Write(numero.getNumero());
        }

        public void visitaSoma(Soma soma)
        {
            Console.Write("(");
            soma.getEsquerda().aceita(this);
            Console.Write(" + ");
            soma.getDireita().aceita(this);
            Console.Write(")");
        }

        public void visitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.getEsquerda().aceita(this);
            Console.Write(" + ");
            subtracao.getDireita().aceita(this);
            Console.Write(")");
        }

        public void visitaDivisao(Divisao divisao)
        {
            Console.Write("(");
            divisao.getEsquerda().aceita(this);
            Console.Write(" / ");
            divisao.getDireita().aceita(this);
            Console.Write(")");
        }

        public void visitaRaizQuadrada(RaizQuadrada raiz)
        {
            Console.Write("(");
            Console.Write("^");
            raiz.getExpressao().aceita(this);
            Console.Write(")");
        }

        public void visitaMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.getEsquerda().aceita(this);
            Console.Write(" / ");
            multiplicacao.getDireita().aceita(this);
            Console.Write(")");
        }
    }
}
