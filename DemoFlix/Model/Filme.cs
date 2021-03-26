using DemoFlix.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFlix.Model
{
    public class Filme : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public Filme(Genero genero, string titulo, string descricao, int ano)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }
    }
}
