using System.Collections.Generic;

namespace LaboratorioUm.Classes
{
    public class Pacote
    {
        public IList<Revista> Revistas { get; private set; }
        public double ValorMensal { get; private set; }
        public string Status { get; private set; }

        public Pacote(IList<Revista> revistas, double valorMensal)
        {
            if (revistas == null || valorMensal < 0)
                throw new System.ArgumentException("Revista invalida");

            Revistas = revistas;
            ValorMensal = valorMensal;
            Status = "Pendente";
        }

        public void DisponibilizarPacote()
        {
            Status = "Disponivel";
        }

        public void ArquivarPacote()
        {
            Status = "Arquivado";
        }

        public void Adicionar(Revista revista)
        {
            Revistas.Add(revista);
        }

        public void Remover(Revista revista)
        {
            Revistas.Remove(revista);
        }
    }
}
