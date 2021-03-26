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
        private LocadouraContext contexto;

        public SerieRepositorio()
        {
            this.contexto = new LocadouraContext();
        }

        public void Atualizar(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
