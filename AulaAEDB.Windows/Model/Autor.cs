using AulaAEDB.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Model
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Autor> ListaTodos()
        {
            return (from p in DataHelper.ListaAutor select p).ToList();
        }

        public static Autor? Seleciona(int Id)
        {
            return (from p in DataHelper.ListaAutor where p.Id == Id select p).FirstOrDefault();
        }

        public void Incluir()
        {
            Autor? oAutorSelecionado = Autor.Seleciona(this.Id);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no Autor {oAutorSelecionado.Id}");
            }
            else
            {
                DataHelper.ListaAutor.Add(this);
            }
        }

        public static void Alterar(Autor oAutor)
        {
            Autor? oAutorColecao = Autor.Seleciona(oAutor.Id);

            if (oAutorColecao == null)
            {
                throw new Exception($"O código informado não foi encontrado");
            }
            else
            {
                oAutorColecao.Nome = oAutor.Nome;
            }
        }

        public void Excluir(){
            Autor? oAutorColecao = Autor.Seleciona(this.Id);

            if (oAutorColecao == null)
            {
                throw new Exception($"O código informado não foi encontrado");
            }
            else
            {
                DataHelper.ListaAutor.Remove(oAutorColecao);
            }
        }
    }
}
