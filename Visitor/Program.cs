using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {

             // A(5) = (5+5) - 5
            Expressao A = new Subtracao( new Soma(new Numero(5), new Numero(5)) , new Numero(5));

            //B(5) = 10 - 5
            Expressao B = new Subtracao(new Numero(10), new Numero(5));

            //conta(10) = Raiz( (5+5) )
            Expressao conta = new Soma(B, A);
            Visitor visitor = new Impressora();
            conta.aceita(visitor);


            /*double resultado = new RaizQuadrada(new Soma(B, A)).avalia();

            Console.WriteLine(resultado);*/
        }
    }
}
