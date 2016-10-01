namespace LaboratorioDois
{
    public class Despesa
    {
        public enum TipoDeDespesa { Almoco, Jantar, PassagensAereas }
        public TipoDeDespesa Tipo { get; set; }
        public double Valor { get; set; }

        public bool EhRefeicao(TipoDeDespesa tipo)
        {
            return (tipo == TipoDeDespesa.Almoco || tipo == TipoDeDespesa.Jantar);
        }

        public bool EstaExcedente()
        {
            return ((Valor > 1000 && Tipo == TipoDeDespesa.Almoco) ||
                    (Valor > 800 && Tipo == TipoDeDespesa.Jantar));
        }

        public string VerificarTipoDeDespesa(TipoDeDespesa tipo)
        {
            switch (tipo)
            {
                case TipoDeDespesa.Almoco:
                    return "Almoço";
                case TipoDeDespesa.Jantar:
                    return "Jantar";
                case TipoDeDespesa.PassagensAereas:
                    return "Passagens aéreas";
                default:
                    return "não-definido";
            }
        }
    }
}
