using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Soma : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Soma(Expressao esquerda, Expressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public Expressao getDireita()
        {
            return esquerda;
        }

        public Expressao getEsquerda()
        {
            return direita;
        }

        public void aceita(Visitor visitor)
        {
            visitor.visitaSoma(this);
        }

        public double avalia()
        {
            return esquerda.avalia() + direita.avalia();
        }
    }
}
