namespace InterpreterPattern
{
    public class Somar : IOperador
    {

        private IOperador esquerda;
        private IOperador direita;

        public Somar(IOperador esquerda, IOperador direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Interpretar()
        {
            return this.esquerda.Interpretar() + this.direita.Interpretar();
        }

    }
}
