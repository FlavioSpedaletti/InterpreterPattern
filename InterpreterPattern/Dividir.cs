namespace InterpreterPattern
{
    public class Dividir : IOperador
    {

        private IOperador esquerda;
        private IOperador direita;

        public Dividir(IOperador esquerda, IOperador direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Interpretar()
        {
            return this.esquerda.Interpretar() / this.direita.Interpretar();
        }
    }
}
