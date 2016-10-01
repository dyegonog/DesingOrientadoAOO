using Laboratorio_3;
using System.Collections.Generic;

namespace Aplicacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            var despesa_1 = new DespesaComPassagemAerea();
            despesa_1.Valor = 10.0;

            var despesa_2 = new DespesaComAlmoco();
            despesa_2.Valor = 20.0;

            IList<Despesa> despesas = new List<Despesa> { despesa_1, despesa_2 };

            var impressora = new Impressora();

            var relatorioDeDespesa = new RelatorioDeDespesas();
            relatorioDeDespesa.ImprimirRelatorio(impressora, despesas);
        }
    }
}
