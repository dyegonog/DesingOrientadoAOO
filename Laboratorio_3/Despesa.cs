namespace Laboratorio_3
{
    public abstract class Despesa
    {
        public double Valor { get; private set; }

        public Despesa(double valor)
        {
            Valor = valor;
        }

        public abstract bool EhRefeicao();
        public abstract bool EstaExcedente();
        public abstract string ObterNomeDaDespesa();
    }
}
