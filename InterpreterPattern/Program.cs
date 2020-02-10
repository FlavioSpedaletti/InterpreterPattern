using System.Diagnostics;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperador somar = new Somar(new Numero(1), new Numero(4));
            Debug.WriteLine(somar.Interpretar());

            IOperador subtrair = new Subtrair(somar, new Numero(2));
            Debug.WriteLine(subtrair.Interpretar());

            IOperador multiplicar = new Multiplicar(subtrair, somar);
            Debug.WriteLine(multiplicar.Interpretar());

            IOperador dividir = new Dividir(new Numero(30), multiplicar);
            Debug.WriteLine(dividir.Interpretar());
        }
    }
}
