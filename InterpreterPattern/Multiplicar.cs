namespace InterpreterPattern
{
    public class Multiplicar : IOperador
    {

        private IOperador esquerda;
        private IOperador direita;

        public Multiplicar(IOperador esquerda, IOperador direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Interpretar()
        {
            return this.esquerda.Interpretar() * this.direita.Interpretar();
        }
    }
}
