using AulaAEDB.Windows.Helper;
using Microsoft.Data.SqlClient;
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
            //return (from p in DataHelper.ListaGenero select p).ToList();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Genero";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Genero> Retorno = new List<Genero>();
                while (oDr.Read())
                {
                    Retorno.Add(new Genero
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public static Genero? Seleciona(int Id)
        {
            //return (from p in DataHelper.ListaGenero where p.Id == Id select p).FirstOrDefault();
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Genero WHERE id={Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Genero? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Genero
                    {
                        Id = oDr.GetInt32(oDr.GetOrdinal("id")),
                        Nome = oDr.GetString(oDr.GetOrdinal("Nome"))
                    };
                }
                oDr.Close();

                return Retorno;
            }
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
            //Genero? oGeneroSelecionado = Genero.Seleciona(this.Id);
            //if (oGeneroSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no Gênero {oGeneroSelecionado.Id}");
            //}
            //else
            //{
            //    DataHelper.ListaGenero.Add(this);
            //}

            using (var ocn = DataHelper.Conexao())
            {
                string sql = "INSERT INTO Genero (Nome) VALUES (@Nome)";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@Nome", this.Nome);
                oCmd.ExecuteNonQuery();
            }
        }

        public static void Alterar(Genero oGenero)
        {
            //Genero? GeneroColecao = Seleciona(oGenero.Id);

            //if (GeneroColecao == null)
            //{
            //    throw new Exception("O Gênero informado não foi encontrado no contexto");
            //}
            //else
            //{
            //    GeneroColecao.Nome = oGenero.Nome;
            //}

            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"UPDATE Genero SET Nome='{oGenero.Nome.Replace("'", "")}' WHERE id={oGenero.Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"DELETE FROM Genero WHERE id={this.Id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
