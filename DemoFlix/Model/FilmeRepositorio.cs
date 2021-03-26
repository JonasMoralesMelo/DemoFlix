using DemoFlix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFlix.Model
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaSerie = new List<Filme>();
        private LocadoraContext contexto;

        public FilmeRepositorio()
        {
            contexto = new LocadoraContext();
        }

        public void Atualizar(int id, Filme entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Filme filme)
        {
            contexto.Filmes.Add(filme);
            contexto.SaveChanges();
        }

        public List<Filme> Lista()
        {
            return contexto.Filmes.ToList();
        }

        public Filme RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
