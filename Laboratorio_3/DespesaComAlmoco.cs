namespace Laboratorio_3
{
    public class DespesaComAlmoco : Despesa
    {
        public DespesaComAlmoco(double valor) : base(valor) { }

        public override bool EhRefeicao()
        {
            return true;
        }

        public override bool EstaExcedente()
        {
            return (Valor > 1000);    
        }

        public override string ObterNomeDaDespesa()
        {
            return "Almoço";
        }
    }
}
