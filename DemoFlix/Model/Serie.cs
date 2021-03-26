using DemoFlix.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFlix.Model
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Serie(Genero genero, string titulo, string descricao)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
        }
        
    }

}
