using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Numero : Expressao
    {
        private double numero;

        public Numero(double numero) {
            this.numero = numero;
        }

        public double getNumero()
        {
            return numero;
        }

        public void aceita(Visitor visitor)
        {
            visitor.visitaNumero(this);
        }

        public double avalia()
        {
            return this.numero;
        }
    }
}
