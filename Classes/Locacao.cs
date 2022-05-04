using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62_Exe2.Classes
{
    internal class Locacao
    {
        private DateTime dtLocacao;

        public DateTime DtLocacao
        {
            get { return dtLocacao; }
            set { dtLocacao = value; }
        }

        private DateTime dtDevolucao;

        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }

        private decimal valorTotal;

        public decimal ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private List<Filme> filmes;

        public List<Filme> Filmes
        {
            get { return filmes; }
            set { filmes = value; }
        }




        public void AlugarFilmes()
        {
            MessageBox.Show("Filmes alugados");

            foreach (var filme in Filmes)
            {
                MessageBox.Show(filme.Nome);
            }
        }

    }
}
