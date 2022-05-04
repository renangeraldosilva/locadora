using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula62_Exe2.Classes
{
    internal class Filme
    {
        public Filme(string nome, int id, string genero, int classiIndicativa)
        {
            this.nome = nome;
            this.id = id;
            this.genero = genero;
            this.classiIndicativa = classiIndicativa;
        }

        public Filme()
        {

        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private int classiIndicativa;

        public int ClassiIndicativa
        {
            get { return classiIndicativa; }
            set { classiIndicativa = value; }
        }

    }
}
