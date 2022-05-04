using Aula62_Exe2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62_Exe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var locacao = criarLocacao();
            locacao.Cliente = criarCliente();
            locacao.Filmes = criarfilmes();
            locacao.AlugarFilmes();
        }

        private Cliente criarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBoxCliente.Text;
            cliente.Cpf = int.Parse(textBox5.Text);
            cliente.Endereco = texBoxCPF.Text;
            cliente.DataNasc = DateTime.ParseExact(textBoxDtNasc.Text, "dd/MM/yyyy", null);
            return cliente;
        }

        private List<Filme> criarfilmes()
        {
            List<Filme> listaFilmes = new List<Filme>();
           
            FilmeRepository filmeRepository = new FilmeRepository();
            var filme1 = filmeRepository.ObterPorID(int.Parse(textBox3.Text)).FirstOrDefault();
            var filme2 = filmeRepository.ObterPorID(int.Parse(textBox6.Text)).FirstOrDefault();
            var filme3 = filmeRepository.ObterPorID(int.Parse(textBox4.Text)).FirstOrDefault();

            if (filme1 == null)
            {
                throw new Exception("Filme 1 invalido");
            }
            else if (filme2 == null)
            {
                throw new Exception("Filme 2 invalido");
            }
            else if(filme3 == null)
            {
                throw new Exception("Filme 3 invalido");
            }
            else
            {
                listaFilmes.Add(filme1);
                listaFilmes.Add(filme2);
                listaFilmes.Add(filme3);
            }

            return listaFilmes;
        }

        private Locacao criarLocacao()
        {
            Locacao locacao = new Locacao();
            locacao.DtLocacao = DateTime.ParseExact(textBox2.Text, "dd/MM/yyyy", null);
            locacao.DtDevolucao = DateTime.ParseExact(textBox1.Text, "dd/MM/yyyy", null);
            locacao.ValorTotal = decimal.Parse(textBoxValorTotal.Text);
            return locacao;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
