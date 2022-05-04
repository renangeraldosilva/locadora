using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula62_Exe2.Classes
{
    internal class Cliente
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        private int cpf;

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string endereco;

        public  string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }
}
