using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Divisao : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Divisao(Expressao esquerda, Expressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void aceita(Visitor visitor)
        {
            visitor.visitaDivisao(this);
        }

        public double avalia()
        {
            return esquerda.avalia() / direita.avalia();
        }

        public Expressao getEsquerda()
        {
            return esquerda;
        }

        public Expressao getDireita()
        {
            return direita;
        }
    }
}
