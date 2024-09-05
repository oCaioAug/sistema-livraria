using AulaAEDB.Windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Interfaces
{
    public interface IRepositorioEditora
    {
        void Adicionar(Editora editora);
        void Atualizar(Editora editora);
        void Excluir(Editora editora);
        List<Editora> Listar();
        Editora ObterPorId(int id);
    }
}
