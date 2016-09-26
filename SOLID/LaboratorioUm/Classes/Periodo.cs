using System;

namespace LaboratorioUm.Classes
{
    public class Periodo
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public Periodo(DateTime dataInicial, DateTime dataFinal)
        {
            if (dataFinal < dataInicial)
                throw new System.ArgumentException("Data invalida");

            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }
    }
}
