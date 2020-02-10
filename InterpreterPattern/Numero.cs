namespace InterpreterPattern
{
    public class Numero : IOperador
    {

        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Interpretar()
        {
            return this.numero;
        }
    }
}
