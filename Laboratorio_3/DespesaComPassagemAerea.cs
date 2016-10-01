namespace Laboratorio_3
{
    public class DespesaComPassagemAerea : Despesa
    {
        public DespesaComPassagemAerea(double valor) : base(valor) { }

        public override bool EhRefeicao()
        {
            return false;
        }

        public override bool EstaExcedente()
        {
            return false;
        }

        public override string ObterNomeDaDespesa()
        {
            return "Passagem Aerea";
        }
    }
}
