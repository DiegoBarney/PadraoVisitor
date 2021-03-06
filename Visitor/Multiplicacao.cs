﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Multiplicacao : Expressao
    {
        private Expressao esquerda;
        private Expressao direita;

        public Multiplicacao(Expressao esquerda, Expressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void aceita(Visitor visitor)
        {
            visitor.visitaMultiplicacao(this);
        }

        public Expressao getEsquerda()
        {
            return esquerda;
        }

        public Expressao getDireita()
        {
            return direita;
        }


        public double avalia()
        {
            return esquerda.avalia() * direita.avalia();
        }
    }
}
