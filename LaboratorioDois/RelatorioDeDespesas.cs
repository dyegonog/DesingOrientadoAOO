using System;
using System.Collections.Generic;

namespace LaboratorioDois
{
    public class RelatorioDeDespesas
    {
        public void ImprimirRelatorio(Impressora impressora, IEnumerable<Despesa> despesas)
        {
            var totalAlimentacao = 0.0;
            var total = 0.0;

            impressora.Imprimir($"Relatório de despesas do dia: {DateTime.Today}");

            foreach (var despesa in despesas)
            {

                if (despesa.EhRefeicao(despesa.Tipo))
                {
                    totalAlimentacao += despesa.Valor;
                }

                var nomeDaDespesa = despesa.VerificarTipoDeDespesa(despesa.Tipo);

                var excedente = " ";

                if (despesa.EstaExcedente())
                {
                    excedente = "X";
                }

                impressora.Imprimir($"{excedente}{nomeDaDespesa} - {despesa.Valor:C}");

                total += despesa.Valor;
            }

            impressora.Imprimir($"Despesas com alimentação: {totalAlimentacao:C}");
            impressora.Imprimir($"Total das despesas: {total:C}");
        }
    }
}
