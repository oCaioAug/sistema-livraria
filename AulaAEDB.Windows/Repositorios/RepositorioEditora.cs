using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaAEDB.Windows.Interfaces;
using AulaAEDB.Windows.Model;

namespace AulaAEDB.Windows.Repositorios
{
    public class RepositorioEditora : IRepositorioEditora
    {
        public void Adicionar(Editora editora)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Editora editora)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Editora editora)
        {
            throw new NotImplementedException();
        }

        public List<Editora> Listar()
        {
            throw new NotImplementedException();
        }

        public Editora ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        List<Editora> IRepositorioEditora.Listar()
        {
            throw new NotImplementedException();
        }

        Editora IRepositorioEditora.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
