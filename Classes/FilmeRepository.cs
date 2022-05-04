using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula62_Exe2.Classes
{
    public class FilmeRepository
    {
        internal List<Filme> ObterPorID(int id)
        {
            List<Filme> lista = new List<Filme>();
            lista.Add(new Filme("Velozes e Furiosos 1", 1, "Ação", 14));
            lista.Add(new Filme("Homem Aranha", 2, "Aventura", 12));
            lista.Add(new Filme("Velozes e Furiosos 8", 3, "Ação", 16));
            lista.Add(new Filme("Capitão America", 4, "Ação e Aventura", 16));
            lista.Add(new Filme("Gente Grande", 5, "Comedia", 10));
            lista.Add(new Filme("O Mentiroso", 6, "Comedia", 14));

            return lista.Where(x => x.ID == id).ToList();
        }
    }
}
