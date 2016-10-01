using LaboratorioDois;
using System.Collections.Generic;

namespace Aplicacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            var despesa_1 = new Despesa();
            despesa_1.Tipo = Despesa.TipoDeDespesa.Jantar;
            despesa_1.Valor = 10.0;

            var despesa_2 = new Despesa();
            despesa_2.Tipo = Despesa.TipoDeDespesa.Almoco;
            despesa_2.Valor = 20.0;

            IList<Despesa> despesas = new List<Despesa> { despesa_1, despesa_2};

            var impressora = new Impressora();

            var relatorioDeDespesa = new RelatorioDeDespesas();
            relatorioDeDespesa.ImprimirRelatorio(impressora, despesas);
        }
    }
}
