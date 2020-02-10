namespace InterpreterPattern
{
    public class Subtrair : IOperador
    {

        private IOperador esquerda;
        private IOperador direita;

        public Subtrair(IOperador esquerda, IOperador direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Interpretar()
        {
            return this.esquerda.Interpretar() - this.direita.Interpretar();
        }
    }
}
