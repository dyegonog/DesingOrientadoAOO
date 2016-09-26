using System;

namespace LaboratorioUm.Classes
{
    public class Assinatura
    {
        public Assinante Assinante { get; private set; }
        public Pacote Pacote { get; private set; }
        public double Valor { get; private set; }
        public Periodo Periodo { get; private set; }

        public Assinatura(Assinante assinante, Pacote pacote)
        {
            if (assinante == null || pacote == null)
                throw new System.ArgumentException("Assinante ou pacote invalido !!!");

            Assinante = assinante;
            Pacote = pacote;
            Valor = pacote.ValorMensal;
            Periodo = new Periodo(DateTime.Now, DateTime.Now.AddYears(1));
        }

        public void AdicionarCupomDeDesconto(Cupom cupom)
        {
            Valor -= cupom.Valor;
        }
    }
}
