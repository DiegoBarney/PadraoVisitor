using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Subtracao : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Subtracao(Expressao esquerda, Expressao direita) {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void aceita(Visitor visitor)
        {
            visitor.visitaSubtracao(this);
        }

        public double avalia()
        {
            return esquerda.avalia() - direita.avalia();
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
