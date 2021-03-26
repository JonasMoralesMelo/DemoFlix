using DemoFlix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFlix.Model
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        private LocadoraContext contexto;

        public SerieRepositorio()
        {
            this.contexto = new LocadoraContext();
        }

        public void Atualizar(int id, Serie entidade)
        {
            var serie = contexto.Series.Find(id);
            serie.Genero = entidade.Genero;
            serie.Titulo = entidade.Titulo;
            serie.Descricao = entidade.Descricao;
           
            contexto.Series.Update(serie);
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var serieBD = contexto.Series.Find(id);
            contexto.Series.Remove(serieBD);
            contexto.SaveChanges();
           
        }

        public void Insere(Serie serie)
        {
            contexto.Series.Add(serie);
            contexto.SaveChanges();
        //   listaSerie.Add(serie);
        }

        public List<Serie> Lista()
        {
            return contexto.Series.ToList();
        }

        public Serie RetornaPorId(int id)
        {
            return contexto.Series.Find(id);
        }
    }
}
