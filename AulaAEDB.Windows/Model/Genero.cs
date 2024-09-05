using AulaAEDB.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAEDB.Windows.Model
{
    public class Genero
    {
        public int Id { get; set; }
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome do gênero é obrigatório");
                _Nome = value.Replace("'", "");
            }
        }
        //public string Nome { get; set; }


        public static List<Genero> ListaTodos()
        {
            return (from p in DataHelper.ListaGenero select p).ToList();
        }

        public static Genero? Seleciona(int Id)
        {
            return (from p in DataHelper.ListaGenero where p.Id == Id select p).FirstOrDefault();
        }

        public static void IncluirGeneroEstatico(Genero oGenero)
        {
            Genero? oGeneroSelecionado = Genero.Seleciona(oGenero.Id);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no Gênero {oGeneroSelecionado.Id}");
            }
            else
            {
                DataHelper.ListaGenero.Add(oGenero);
            }
        }

        public void Incluir()
        {
            Genero? oGeneroSelecionado = Genero.Seleciona(this.Id);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no Gênero {oGeneroSelecionado.Id}");
            }
            else
            {
                DataHelper.ListaGenero.Add(this);
            }
        }

        public static void Alterar(Genero oGenero)
        {
            Genero? GeneroColecao = Seleciona(oGenero.Id);

            if (GeneroColecao == null)
            {
                throw new Exception("O Gênero informado não foi encontrado no contexto");
            }
            else
            {
                GeneroColecao.Nome = oGenero.Nome;
            }
        }

        public void Excluir()
        {
            DataHelper.ListaGenero.Remove(this);
        }
    }
}
