using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public interface Expressao
    {
        double avalia();
        public void aceita(Visitor visitor);
    }
}
