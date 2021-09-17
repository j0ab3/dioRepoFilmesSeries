using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme objeto)
        {
            listaFilme[id] = objeto;
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
            throw new NotImplementedException();
        }

        public void Insere(Filme objeto)
        {

            listaFilme.Add(objeto);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaporID(int id)
        {
            return listaFilme[id];
        }
    }
}